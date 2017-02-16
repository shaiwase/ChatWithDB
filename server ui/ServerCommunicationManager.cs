using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
  

    /// <summary>
    /// This class implements the logic of the server side in the chat implementation.
    /// </summary>


namespace server_ui
{
    public class ServerCommunicationManager
    {
        #region Members

        //Variable members related to networking
        private string _serverIP = "127.0.0.1"; //Set the server IP
        private int _port = 4000; //Set the server _port
        readonly TcpListener _serverListener = null;
        TcpClient _client;
       // private string _clientStatus = string.Empty;

        //Variable members related to logs
        private readonly Dictionary<string, string> _ClientConnected; //Creates a new dictionary variable
        private int _clientsCounter = 0; //Set the client connected counters to 0


        //Variable members related to Streaming and file R-W
        private NetworkStream _networkStream; //Declares a NetworkSteam instance to send and receive the messages
        private BinaryReader _readerr; //Declares a new reader to receive the client messages
        private BinaryWriter _writerr; //Declare a new writer instance to send the received messages to the connected clients
      
        //Variable member for reference to Server Gui
        private readonly ServerGUI _serverGui;

        //Variable member for event to register to event when closing the window
        private readonly ManualResetEvent _evClose = new ManualResetEvent(false);

        //Variables related to Threads
        private Thread _BroadcastMessages; //Declares a Thread to broadcast messages to connected clients
        private Thread _BroadcastFile; //Declares a Thread to broadcast file to connected clients **** still not implemented. For future use. //TODO
        private readonly object _locker = new object(); //Creates a locking object

        #endregion

        /// <summary>
        /// Ctor - initialize a thread to accept a new _client connection.
        /// </summary>
        public ServerCommunicationManager(ServerGUI serverfrm)
        {
            _ClientConnected = new Dictionary<string, string>();
            _serverGui = serverfrm;
            _serverListener = new TcpListener(IPAddress.Parse(_serverIP), _port); //Server start lessoning for connections
            _serverListener.Start();
            var mRegister = new Thread(AcceptClientConnections);
            mRegister.Start();
        }

        /// <summary>
        /// Empty Ctor
        /// </summary>
        public ServerCommunicationManager()
        {

        }

        /// <summary>
        /// Accept clients connection and add username and message _client to the CLientConnected dictionary.
        /// The server will use the dictionary to broadcast the messages to all the connected users.
        /// </summary>
        private void AcceptClientConnections()
        {
            try
            {
                while (!_evClose.WaitOne(10, false)) //Infinite loop monitoring for _client connections requests.
                {
                    _client = _serverListener.AcceptTcpClient(); //Waits for the Client To Connect

                    if (_client.Connected) // If you are connected
                    {
                        _networkStream = _client.GetStream();
                        _readerr = new BinaryReader(_networkStream);

                        lock (_locker)//lock the current thread so the next thread will be able to access only once previous thread ends its work.
                            
                        {
                            _clientsCounter++;
                        }

                        string userTimeConnection = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff",
                            CultureInfo.InvariantCulture);
                        string username = _readerr.ReadString(); //read the connected username from stream
                        string userIp = _readerr.ReadString(); //read the connected IP from stream

                        AddUser(username, userIp); //Call mth to add the username to the dictionary
                        _serverGui.UpdateUserLogListBox(username, false);
                        //Update serverGui to log the connected username.
                        _serverGui.UpdateUserIpAndTimeLogListBox(userIp, userTimeConnection, false);
                        //Update serverGui to log the connected _client ip and time of connection

                        _BroadcastMessages = new Thread(() => BroadCastMessages(_ClientConnected));
                        //Start new thread to lesson to _client messages and call the broadcast messages
                        _BroadcastMessages.Start();
                    }
                }
            }
            catch
            {
                MessageBox.Show(@"Registration succeded");
            }
        }

        /// <summary>
        /// This method broadcast the messages to all connected users
        /// </summary>
        /// <param name="clientsConnected"></param>
        private void BroadCastMessages(Dictionary<string, string> clientsConnected)
        {
            try
            {
                _readerr = new BinaryReader(_client.GetStream());
                _writerr = new BinaryWriter(_client.GetStream());
                while (true)
                {
                    string message = _readerr.ReadString();
                    string userName = message.Substring(0, message.IndexOf(' '));//extract the username from the message
                    string messageSent = message.Split(' ').Last(); //extract the last word from the message 
                    bool isFile; //For future use. Not implemented. //TODO

                    foreach (var c in clientsConnected)
                    {
                        _writerr.Write(message);
                    }
                    _serverGui.UpdateTxtBoxMsgs(message);

                    if (messageSent == "disconnecting") //if the string sent by the _client is "disconnecting"
                    {
                       RemoveUser(userName, clientsConnected); //call the mth to remove the user
                    }
                 }
            }
            catch (Exception ex)
            {
                 ex.ToString();
            }
        }

        /// <summary>
        /// Add user to the dictionary when the user is connecting
        /// </summary>
        /// <param name="username"></param>
        /// <param name="ipFromClient"></param>
        private void AddUser(string username, string ipFromClient)
        {
            _ClientConnected.Add(username, ipFromClient); //Add the _client number to the dictionary
        }

        /// <summary>
        /// Remove the user from the dictionary when the user is disconnecting + reduce the counter of connected clients
        /// </summary>
        /// <param name="username"></param>
       /// <param name="clientConnected"></param>
        private void RemoveUser(string username, Dictionary<string,string> clientConnected)
        {
            if (username == null) throw new ArgumentNullException(nameof(username));
            if (clientConnected == null) throw new ArgumentNullException(nameof(clientConnected));

           try {
                if (clientConnected.Remove(username))
                {
                    _clientsCounter--; //Reduce the counter when a client disconnects.
                }
             }
            catch (Exception ex)
            {
                throw ex;
            }
          }

    }
}
 
