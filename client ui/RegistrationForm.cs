using System;
using System.Windows.Forms;
 
//This class implement the registration Gui form for new users. 
 

namespace client_ui
{
    public partial class RegistrationForm : Form
    {

        #region members

        private CommunicationManager _communicationManager;
        private RegistrationForm _registrationForm;


        #endregion
        public RegistrationForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On form loading, new connection to SQL DB will be initialized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
             _registrationForm = new RegistrationForm();
        }

        /// <summary>
        /// This Mth is calling the logic for registering a new user in DB 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Register_Click(object sender, System.EventArgs e)
        {
            try
            {
                bool isUserExist = false;
                _communicationManager = new CommunicationManager();//Creates a new instance of client communication manager (client logic)
                string userToRegister = txt_UserRegistration.Text;//Set the user from the textbox to be the new user to register
                string nickNameToRegister = txt_NickNameRegistration.Text;//Set the nickname from the textbox to be the new nickname to register
                bool isRegistrationSuccess = _communicationManager.RegisterNewUser(userToRegister, nickNameToRegister);//Call the CM logic to register the new user.
 
                if (isRegistrationSuccess)
                {
                   // isRegistrationSuccess = true; //todo - check if this var is needed
                    MessageBox.Show(@"Registration succeded");//If the registration succeded, pop up a success message
                }
                else
                {
                    isRegistrationSuccess = false;
                    MessageBox.Show(@"Registration did not succeded");
                }
            }
            catch (Exception ex )
            {
                throw ex;
            }
    //Check if user exist in DB.
    //IF exist, connect, else
}
      
        /// <summary>
        /// Method to nicely close the registration form window asking if the user is sure he wants to close this registration form window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show(@"Are you sure you want to exit ?",@"Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                _registrationForm.Close(); //Close the registration form if yes button is pressed.
            }
            else if (dialog == DialogResult.No) 
            {
                e.Cancel = true; //Cancel the form closure if no button is pressed.
            }
        }
        
        /// <summary>
        /// This method close the registration form window when pressing on exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExitRegistrationForm_Click(object sender, EventArgs e)
        {
            Close();//This current form closes.
        }
    }
}
