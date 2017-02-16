using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

///This class is used to implement the search message gui but also contains the logic using ADO.NET 
///(would have been preferable to put the logic in another class) 

namespace server_ui
{
    public partial class SearchDbTable : Form
    {

        #region Members

        //Variable member used for SQL connection
        private SqlConnection _sqlConnection;
        private SqlDataAdapter _sqlDataAdapter;
        private DataTable _datatable;

        #endregion
        public SearchDbTable()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method used to search a message by word or date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_MessageValue_TextChanged(object sender, EventArgs e)
        {
            if (cmb1_msgSearch.Text == @"Word")
            {
                string searchByWord = txtBox_MessageValue.Text; //Set the word to search from the txt box
                string querySelectByWord = "SELECT Id, MessageText, NickName, MessageDate FROM Messages WHERE MessageText LIKE '" + searchByWord + "%'";//set the query as string
                SearchInDb(querySelectByWord, false);
            }
        }
        
        /// <summary>
        /// Method to search a user by its Id or NickName
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_UserOrIdValue_TextChanged(object sender, EventArgs e)
        {
            if (cmb2_UserSearch.Text == @"Id")
            {
                string searchById = txtBox_UserOrIdValue.Text;
                string querySelectById = "SELECT Id, Name, NickName, LastConnectionDate, IsConnected FROM Users WHERE Id LIKE '" + searchById + "%'";
                SearchInDb(querySelectById, true);//call SearchDB method to find the user by its Id. Param sent are query and true boolean for user search
            }

            else if (cmb2_UserSearch.Text == @"NickName")
            {
                string searchByNickName = txtBox_UserOrIdValue.Text;
                string querySelectByNickName = "SELECT Id, Name, NickName, LastConnectionDate, IsConnected FROM Users WHERE NickName LIKE '" + searchByNickName + "%'";
                SearchInDb(querySelectByNickName, true);//call SearchDB method to find the user by its nickname. Param sent are query and true boolean for user search
            }
        }

        /// <summary>
        /// Method to delete user from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            string userToDelete = txtBox_DeleteUser.Text; //set the nickname to delete
            string queryDeleteUser = "DELETE FROM Users where NickName = '"  + userToDelete +  "'"; //set the sql cmd to send for deletion of the row relevant to the nickname
            DeleteUserFromDb(queryDeleteUser, userToDelete); //call the deletion method and pass the query + nickname to search for deletion
        }

        /// <summary>
        /// Method to popup a message when date is selected at combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb1_msgSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb1_msgSearch.Text == @"Date")
            {
              MessageBox.Show(@"Please select the relevant date from the calendar");  
            }
        }

        /// <summary>
        /// Method to search a message when selecting a date from the calendar and pressing on the search button. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime searchByDate = dateTimePicker.Value; //set the calendar value as a datetime variable (could not define it as string)
            string shortDate = searchByDate.ToShortDateString(); //change the date to be short with not time 
            string querySelectByDate = "SELECT Id, MessageText, NickName, MessageDate From Messages WHERE MessageDate ='" + shortDate + "'"; //set the query as string
            SearchInDb(querySelectByDate, false); //call the method to search for the relevant records in db 
        }

        /// <summary>
        /// Method used to find specific values in DB and display them to the datagriedview.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="searchUser">True if search by user, false is search by message</param>
        private void SearchInDb(string query, bool searchUser)
        {
            using (_sqlConnection = new SqlConnection(DbHelperServer.ChatDbConnection))
            {
                _sqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand(query, _sqlConnection); //Pass the string query to a new instance of SQLCmd
                _sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                _datatable = new DataTable(); //creates datatable with re records
                _sqlDataAdapter.Fill(_datatable);//will add the relevant rows to the datatable that will be returned in the gridview as result of the query
                if (!searchUser) //if the search is by message
                    dataGridView1.DataSource = _datatable; //display the relevant rows at griedview
                else //The search is by user
                {
                    dataGridView2.DataSource = _datatable; //display the relevant rows at griedview
                }
            }
        }

        /// <summary>
        /// This method deletes the relevant user from the DB
        /// </summary>
        /// <param name="query"></param>
        private void DeleteUserFromDb(string query, string userToDelete)
        {
            using (_sqlConnection = new SqlConnection(DbHelperServer.ChatDbConnection))
            {
                _sqlConnection.Open();
                SqlCommand sqlCmd = new SqlCommand(query, _sqlConnection);
                int deletedUser = sqlCmd.ExecuteNonQuery(); //execute the deletion command and returns 1 (number of row affected) if succeeded to delete the relevant user

                if (deletedUser == 1) //there was one record successfully deleted
                {
                    MessageBox.Show(@"User " + userToDelete + @" deleted successfully");
                }
                else //the record was not successfully deleted
                {
                    MessageBox.Show(@"Error ! User " + userToDelete + @" could NOT be deleted");
                }
            }
        }
    }
}
