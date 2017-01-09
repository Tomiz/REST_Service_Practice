using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace REST_Service_Practice
{

    /// <summary>
    /// Step 2: Preparing the data to return
    /// </summary>
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public int Price { get; set; }

    }
}