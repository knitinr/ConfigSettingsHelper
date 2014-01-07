ConfigSettingsHelper
====================

The .NET Configuration Settings Helper makes reading from and writing to the application configuration file 
simpler.

Simply add a reference to the ConfigUtilities library and get an instance of the ConfigHelper or the
ConnectionStringHelper class by calling the GetInstance method. Then, access or modify the app setting or
connection string by using the obtained instance indexer.

The following is sample code to demonstrate the use of the ConfigUtilities library:


using ConfigUtilities;

namespace SaveSettingsToAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            var cfg = ConfigHelper.GetInstance();
            var oldval = cfg["TestConfig"]; //this fetches the config value
            cfg["TestConfig"] = "ThisConfig"; //this sets the config value
            
            var cstr = ConnectionStringHelper.GetInstance();
            var oldconnstr = cstr["TestConnStr"]; //this fetches the connection string
            cstr["TestConnStr"] = "ThisConnStr"; //this sets the connection string
        }
    }
}
