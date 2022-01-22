using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase
{
     [Serializable()]
    public class ConnectionClass
    {
        public string serverName { get; set; }
        public string databaseName { get; set; }
        public string timeout { get; set; }
        public string integratedSecurity { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
