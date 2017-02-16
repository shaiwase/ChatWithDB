using System;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using server_ui;

//Simple Chat Program - Karine Or
//The purpose of this class is to be the communication manager for the _client side. All logic from _client to server is implemented here.

namespace client_ui
{
    public class CommunicationManager
    {
        #region   Members

        //Variables related to networking
        private IPAddress _ipAddr; //represents the ip address of the server
        private TcpClient _client; // Creates TCP _client instance
        private int _port = 4000;
        private NetworkStream _networkStream; //Creates a NetworkSteam instance to send and receive the messages
        private FileStream _fileStream;
        private bool _IsConnected { get; set; }


        //Variables members related to Streaming and file R-W
        private BinaryReader _readerr;
        private BinaryWriter _writerr;

        //Variables members related to Threads
        private Thread _messageThread; //Initialize the new thread to read messages sent by the server.
        public ServerCommunicationManager _cmServer = new ServerCommunicationManager();

        //Variable member used for SQL connection
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCmdSelect;
        private SqlCommand _sqlCmdInsert;
        private SqlCommand _sqlCmdUpdate;
        private SqlDataReader _sqlDataReader;

        //Variable members for reference to _client Gui
        ClientChatWindow _frmClientChatWindow;

        //Variable member for closing event
        private ManualResetEvent _eventClose;

        #endregion Members

        /// <summary>
        /// Ctor of the class to initiate a _client communication manager (_client business logic). Object contains event and Async thread mecanism to receive messages
        /// </summary>
        public CommunicationManager()
        {
            _eventClose = new ManualResetEvent(false); //event that tells me if form was close
        }

        /// <summary>
        /// Sets the pointer to the GUI for the updates of text
        /// </summary>
        /// <param name="chat">Reference of GUI of _client</param>
        public void Set(ClientChatWindow chat)
        {
            _frmClientChatWindow = chat;
        }

        /// <summary>
        /// This method connects the _client to the server and sends the userName 
        /// and timestamp's connection. Return true if connection succeds, otherwise false.
        /// </summary>
        /// <param name="clientIp"></param>
        /// <param name="userName"></param>
        /// <param name="client"></param>
        /// <param name="serverIp"></param>
        /// <returns>boolean true or false</returns>
        public bool InitializeConnection(string serverIp, string clientIp, string userName, TcpClient client)
        {
            try
            {
               // _sqlConnection = new SqlConnection(DBHelper.ChatDBConnection);
                _messageThread = new Thread(ReceiveMessages);
                _messageThread.Start();//Starts a thread that constantly listens to new messages
                _ipAddr = IPAddress.Parse(serverIp); //Parse the IP address from the TextBox into an IPAddress object
                client.Connect(_ipAddr.ToString(), _port); //Connect to the server
                _networkStream = client.GetStream(); //Creates the streaming channel to transfer the data

                _writerr = new BinaryWriter(_networkStream);//Creates a new B writter that will to write the streamed data
                _writerr.Write(userName); //sends the _client _username in streaming channel

                _writerr.Write(clientIp); //send sthe _client IPAddr in streaming channel
                DateTime userTimeConnection = DateTime.Now;
                //string userTimeConnection = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture);
                _IsConnected = true;
                UpdateDBwithConnDateAndStatus(userName,userTimeConnection, _IsConnected);//Call method to update userDateTimeConnection and connection state)

                return _IsConnected;
            }
            catch (Exception ex) //If the connection fails, returns exception
            {
                MessageBox.Show(ex.Message);
                return _IsConnected = false;
            }
        }

        /// <summary>
        /// This method is invoked to update the DB Users table with the user connection status and date
        /// </summary>
        private void UpdateDBwithConnDateAndStatus(string userName, DateTime dateTimeConection, bool isconnected)
        {
            using (_sqlConnection = new SqlConnection(DbHelperClient.ChatDbConnection))
                //Initialize connection to SQL using DBhelper static class to get the connection string set in app.config)
            {
                string queryUpdate = $"UPDATE Users SET LastConnectionDate='{dateTimeConection}', IsConnected='{isconnected}' where NickName ='{userName}'";//Update user connection DateTime and connection status
                _sqlCmdUpdate = new SqlCommand(queryUpdate, _sqlConnection);
                _sqlConnection.Open();
                _sqlCmdUpdate.ExecuteNonQuery(); //Execute the insert of new user.
            }
        }

        /// <summary>
        /// Runs in loop until the program is closed and reads incoming messages
        /// </summary>
        private void ReceiveMessages()
        {
            while (!_eventClose.WaitOne(10, false))
            //asks the event if it was set, meaning there was a click on the close of the form
            {
                try
                {
                    if (_networkStream == null) continue;

                    if (_IsConnected && _networkStream != null)
                    {
                        _readerr = new BinaryReader(_networkStream);//Creates a new reader to read the info from the stream channel
                        string message = _readerr.ReadString();
                        PrintMessage(message);// Call Mth to push the msg to the Gui  
                    }
                    else
                    {
                        _readerr.Close();
                    }
                }
                catch
                {
                    // ignored
                }
            }
        }

        /// <summary>
        /// Push the message to the gui
        /// </summary>
        /// <param name="messageWithUser"></param>
        private void PrintMessage(string messageWithUser)
        {
            _frmClientChatWindow.UpdateChatListBox(messageWithUser);// Push the message to the gui
        }

        /// <summary>
        /// Send a message with the _username to the server  
        /// </summary>
        /// <param name="nickName">The _client's user name</param>
        /// <param name="message">The message</param>
        /// <returns></returns>
        public void SendMessage(string message, string nickName)
        {
            try
            {
                if (message.Length > 0)
                {
                    _writerr.Write(nickName + " says: " + message); //Sends the user message
                    SaveChatMessageInDb(nickName, message, DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _networkStream.Flush();
            }
        }

        /// <summary>
        /// This method insert Msg chat text, userID, Msg sent date, RecipientID into the DB table "Messages"
        /// </summary>
        /// <param name="nickName"></param>
        /// <param name="message"></param>
        /// <param name="msgDateTime"></param>
        private void SaveChatMessageInDb(string nickName, string message, DateTime msgDateTime)
        {
            if (message == "disconnecting")
                return;
            using (_sqlConnection = new SqlConnection(DbHelperClient.ChatDbConnection))
                //Initialize connection to SQL using DBhelper static class to get the connection string set in app.config)
            {
                string queryInsert = "INSERT INTO Messages (MessageText, NickName, MessageDate) VALUES('" + message + "','" + nickName + "','" + msgDateTime + "');";
                _sqlCmdInsert = new SqlCommand(queryInsert, _sqlConnection);
                _sqlConnection.Open();
                _sqlCmdInsert.ExecuteNonQuery(); //Execute the insert of new user.

            }
        }

        /// <summary>
        /// This method is called at login stage to check if the nickname is registered in DB. If not, popup a message asking the user to register to the Chat.
        /// </summary>
        /// <param name="nickName"></param>
        /// <returns></returns>
        public bool IsUserRegistered(string nickName)
        {
            bool isUserRegistered = true;
            //Connect to DB Make select to see if the user + nickname exist in DB. if yes, returns true. if false, ask the user to register
            using (_sqlConnection = new SqlConnection(DbHelperClient.ChatDbConnection))//using will take care of closing opened connection once the transaction is done
            {
                string querySelect = "SELECT * FROM Users WHERE NickName = + '" + nickName + "'";//The cmd to run to check if the nickname already exists.
                _sqlCmdSelect = new SqlCommand(querySelect, _sqlConnection);//set the select command with the connection.

                _sqlConnection.Open();//open sql connection
                _sqlDataReader = _sqlCmdSelect.ExecuteReader();//run the cmd.

                if (!_sqlDataReader.HasRows)//if the nickname already exists in DB.
                {
                   isUserRegistered = false; //Set the flat to true.
                }
            }
            return isUserRegistered; //Return the result if exists (false or true)
        }

        /// <summary>
        /// This Mth registers and inserts a new user into the DB if the Nickname is available.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="nickname"></param>
        /// <returns></returns>
        public bool RegisterNewUser(string user, string nickname)
        {
            bool isRegisterSuccess = false;
            string nickNameToRegister = nickname ;

            bool isRegistered = IsNickNameAlreadyInUse(nickNameToRegister, false);//Call Mth to check if the nickname is already registered.

            if (!isRegistered)
            {
                using (_sqlConnection = new SqlConnection(DbHelperClient.ChatDbConnection))//Initialize connection to SQL using DBhelper static class to get the connection string set in app.config)
                {
                    string queryInsert = "INSERT INTO Users (Name, NickName) VALUES('" + user + "','" + nickNameToRegister + "');";
                    _sqlCmdInsert = new SqlCommand(queryInsert, _sqlConnection);                                                                                                                                                                                                                                                                            
                    _sqlConnection.Open();
                    _sqlCmdInsert.ExecuteNonQuery();//Execute the insert of new user.
                    isRegisterSuccess = true;//Set the flag to true
                }
            }
            return isRegisterSuccess;//Return the result of the insert (false or true)
        }

        /// <summary>
        /// This method checks if the NickName already exists in DB
        /// </summary>
        /// <param name="nickNameToRegister"></param>
        /// <param name="isUserAlreadyRegistered"></param>
        /// <returns></returns>
        private bool IsNickNameAlreadyInUse(string nickNameToRegister, bool isUserAlreadyRegistered)
        {
            using (_sqlConnection = new SqlConnection(DbHelperClient.ChatDbConnection))//using will take care of closing opened connection once the transaction is done
            {
                string querySelect = "SELECT * FROM Users WHERE NickName = + '" + nickNameToRegister + "'";//The cmd to run to check if the nickname already exists.
                _sqlCmdSelect = new SqlCommand(querySelect, _sqlConnection);//set the select command with the connection.

                _sqlConnection.Open();//open sql connection
                _sqlDataReader = _sqlCmdSelect.ExecuteReader();//run the cmd.

                if (_sqlDataReader.HasRows)//if the nickname already exists in DB.
                {
                    MessageBox.Show(@"NickName already exists. Please choose a different nickname.");//Pop up a msg.
                    isUserAlreadyRegistered = true; //Set the flat to true.
                }
            }
            return isUserAlreadyRegistered; //Return the result if exists (false or true)
        }

        /// <summary>
        /// Close all connections. 
        /// </summary>
        public bool CloseConnection(string username, TcpClient client, string clientStatus, bool isConnected)
        {
            if (username == null) throw new ArgumentNullException(nameof(username));
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (clientStatus == null) throw new ArgumentNullException(nameof(clientStatus));

            try
            {
                if (client.Connected)
                {
                    SendMessage(clientStatus, username);//send message "disconnected"
                    _messageThread.Abort(); //Close the receiving message thread
                    client.Close(); //close TCP _client connection
                    _networkStream.Close(); //Close the steaming channel
                    isConnected = false;
                    UpdatedDBwithDisconectionStatus(username, false);
                }
            }
            catch (Exception)
            {
                _messageThread.Abort();
                client.Close();
                _networkStream.Close();
            }
            return isConnected;
        }

        private void UpdatedDBwithDisconectionStatus(string userName, bool isconnected)
        {
            using (_sqlConnection = new SqlConnection(DbHelperClient.ChatDbConnection))
            {
                string queryUpdate = $"UPDATE Users SET  IsConnected='{isconnected}' where NickName ='{userName}'";//Update user connection DateTime and connection status
                _sqlCmdUpdate = new SqlCommand(queryUpdate, _sqlConnection);
                _sqlConnection.Open();
                _sqlCmdUpdate.ExecuteNonQuery(); //Execute the insert of new user.
            }
        }

        /// <summary>
        /// Signales that the _client was closed
        /// </summary>
        public void Close()
        {
            _eventClose.Set();
            Application.Exit();
        }


        //TODO will be implemented later. 
        /// <summary>
        /// Sends a file to the stream
        /// </summary>
        /// <param name="fileToSend"></param>
        /// <param name="username"></param>
        /// <param name="ms">Memory stream the contains the original file contents</param>
        /// <param name="result">Whether sending was successful</param>
        /// <returns></returns>
        public void SendFile(string fileToSend, string username)
        {
            try
            {
                if (fileToSend.Length > 0)

                    _writerr.Write(fileToSend);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());

            }
        }

    }
}
