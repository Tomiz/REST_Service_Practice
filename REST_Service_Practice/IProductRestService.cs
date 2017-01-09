using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_Service_Practice
{
    /// <summary>
    /// step 3: Create Service Content
    /// steap 3.1: Create GET request! (http get request)
    /// </summary>
   
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductRestService" in both code and config file together.
    [ServiceContract]
    public interface IProductRestService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, // Response format
                                   BodyStyle = WebMessageBodyStyle.Bare, // not sure
                                   UriTemplate = "GetProductList/")] // URL path and query

        List<Product> GetProductList();
    }
}
