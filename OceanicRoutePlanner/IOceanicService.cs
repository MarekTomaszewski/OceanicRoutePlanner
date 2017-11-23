using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OceanicRoutePlanner
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOceanicService" in both code and config file together.
    [ServiceContract]
    public interface IOceanicService
    {
        [OperationContract]
        List<Connection> GetConnections(string parcelType, int weight, int height, int width, int depth);
    }

    [DataContract]
    public class Connection
    {
        public string Node1 { get; set; }
        public string Node2 { get; set; }
        public int Time { get; set; }
        public decimal Price { get; set; }
    }
}
