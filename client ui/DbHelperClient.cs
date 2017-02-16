using System;
using System.Configuration;

/// <summary>
/// The purpose of this class is to set connection string as "ChatDBConString" - reading App.config file to get the whole connection string (this way it is protecting the con string)
/// </summary>
namespace client_ui
{
    static class DbHelperClient
    {
        public static string ChatDbConnection => ConfigurationManager.ConnectionStrings["ChatDBConString"].ConnectionString;
    }
}
