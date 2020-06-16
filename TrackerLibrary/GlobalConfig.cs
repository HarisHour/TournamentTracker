using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
     public static class GlobalConfig
    {

      
        public static SqlConnector Connection { get; private set; }


        public static void InitializeConnections()
        {          
                Connection = new SqlConnector();
                
           
        }

        public static string CnnString(string name) 
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }

    
}
