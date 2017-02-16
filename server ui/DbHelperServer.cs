using System;
using System.Configuration;

/// <summary>
/// The purpose of this class is to set connection string as "ChatDBConString" - reading App.config file to get the whole connection string (this way it is protecting the con string)
/// </summary>
/// 
namespace server_ui
{
    static class DbHelperServer
    {
       public static String ChatDbConnection => ConfigurationManager.ConnectionStrings["ChatDBConString"].ConnectionString;
    }
}
