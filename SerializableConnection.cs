using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectDataBase
{
     [Serializable()]
    public class SerializableConnection
    {
         public List<ConnectionClass> connectionList = new List<ConnectionClass>();
    }
}
