using System;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Sockets;


//The purpose of this class is to implement the Client UI.

namespace client_ui
{

    public partial class ClientChatWindow
    {
        #region Members

        //Variable members used for the chat
        public string _username; //Client user Nickname

        //Variable members used for networking interactions
        public TcpClient _client; //Declared to create later a new tcp _client to communicate with the server
        bool _isConnected = false;
        private string _clientIPaddr = "127.0.0.1";

       

        private readonly CommunicationManager _communicationManager;   //Declared to create later a new instance of the _client business logic
        
        private string _clientStatus = "disconnected";

        //Variable member used for Gui design
        private Color _color;

        #endregion

        /// <summary>
        /// Client Chat constructor
        /// </summary>
        public ClientChatWindow()
        {
            InitializeComponent();
            _communicationManager = new CommunicationManager();
            //Creates an instance of this class with contains the _client logics to communicate with the server
            _communicationManager.Set(this);
            txtBoxNickName.Text = Environment.UserName; //Set the NickName to be the Windows logged in userName
        }

        /// <summary>
        /// Logs a _client to the server or logs them out when pressing the login button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                if (txtBoxNickName.Text != "" && txtBoxServerIP.Text != "")
                {
                    bool _nickNameCanLogin = _communicationManager.IsUserRegistered(txtBoxNickName.Text);

                    if (!_nickNameCanLogin)
                    {
                        MessageBox.Show(@"You are not registered to Chat. Please register first.");//Popup a message box if the user is not registered.
                    }
                    else //If the user is registered, continues the logic
                    {
                        _client = new TcpClient(); //Start a new TCP _client to connect to the server
                         txtChatText.Text = null;

                    if (_communicationManager.InitializeConnection(txtBoxServerIP.Text, _clientIPaddr,
                        txtBoxNickName.Text, _client))
                    {
                        _username = txtBoxNickName.Text; //Update the gui textbox with _client nickname
                        _clientIPaddr = txtBoxServerIP.Text; //Update the gui with the server IP (local address 127.0.0.1)
                        UpdateOnLogin(true); //Update the gui button states
                        _clientStatus = "connecting";
                        
                    }
                    else
                    {
                        while (txtBoxNickName.Text == "")
                        {
                            MessageBox.Show(@"Please enter a valid nickname");
                        }
                        txtBoxNickName.Text = _username;
                    }
                   }
                }
            }
            else // We are connected, thus disconnect
            {
                try
                {
                    _clientStatus = "disconnecting";
                    if (!_communicationManager.CloseConnection(_username, _client, _clientStatus, _isConnected))
                    {
                        UpdateOnLogin(false);
                       
                        if (!_isConnected)
                            MessageBox.Show(@"Disconnected");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        /// <summary>
        /// This method sends the chat message to the server and adds it the to chat list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtChatText.Text.Length > 0 && _client != null && _isConnected)
                    //Check the msg is not null and the _client is connected
                {
                    _communicationManager.SendMessage(txtChatText.Text, _username);//sends the message to the server with the _username
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Updates the chat window with new messages
        /// </summary>
        /// <param name="value"></param>
        public void UpdateChatListBox(string value)
        {
            if (InvokeRequired) //cares if other thread invokes this box
            {
                Invoke(new Action<string>(UpdateChatListBox), value);
            }
            else
            {
                lstBoxChatText.Items.Add(value); //write the user msg to the listBoxChat window
            }
            Invoke(new Action<string>(ClearChatTxtBox), string.Empty); //Clear the msg text box
        }

        /// <summary>
        /// This method clears the chat text box once user press send
        /// </summary>
        /// <param name="value"></param>
        private void ClearChatTxtBox(string value)
        {
            if (InvokeRequired) //cares if other thread invokes this box
            {
                Invoke(new Action<string>(ClearChatTxtBox), new object[] {value});
                txtChatText.Clear(); //Clear the msg text box
            }
            else
            {
                txtChatText.Clear(); //write the user msg to the listBoxChat window
            }

        }

        /// <summary>
        /// Updates Gui Controls after connecting connecting
        /// </summary>
        /// <param name="state">Login or Log=out</param>
        private void UpdateOnLogin(bool state)
        {
            if (state)
            {
                btn_Connect.Text = @"Log Out";
            }
            else
            {
                btn_Connect.Text = @"Login";
            }
            _isConnected = state; //Helps us track whether we're connected or not
            txtBoxServerIP.Enabled = !state;
            txtBoxNickName.Enabled = !state;
            lstBoxChatText.Enabled = state;
            btn_SendMessage.Enabled = state;
        }

        /// <summary>
        /// Closes the communication reference when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientChatWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _communicationManager.Close();
            _client.Close();
        }
       
        /// <summary>
        /// Method that display a color dialog box to change the text color display in txtchatbox and chatlistbox.
        /// It will change all the text to the same color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TextColor_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();//Create a new instance of ColorDialog box
            col.ShowDialog(); //will chow the dialog box of colors
            _color = col.Color;
            txtChatText.ForeColor = _color;
            lstBoxChatText.ForeColor = _color;
        }

        private void btn_Subscribe_Click(object sender, EventArgs e)
        {
                RegistrationForm registrationForm = new RegistrationForm();  //open registration form
                registrationForm.ShowDialog();
        }


        //TODO - Will be implemented later
        /// <summary>
        ///  Method to browse to the image to send
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_browseToPicture_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();

            string localPath = openFileDialog1.FileName;

            pictureBox1.Image = Image.FromFile(localPath);

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; //Display the image correctly in the picturebox

            txtFilePath.Text = localPath;
        }

        /// <summary>
        /// Method that calls the communication manager to send the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SendFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFilePath.TextLength > 0 && _client != null && _isConnected)//Check the file to send is not null and the _client is connected
                {
                    
                   _communicationManager.SendFile(txtFilePath.Text, _username);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
    }
    }
 
