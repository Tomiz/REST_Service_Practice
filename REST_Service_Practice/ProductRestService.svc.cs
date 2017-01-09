using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace REST_Service_Practice
{
    /// <summary>
    /// step 4: Implementing restful serivce
    /// step 4.1: implement interface
    /// step 4.2: implement missing members from interface
    /// step 4.3: Code the members (methods)
    /// </summary>

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRestService.svc or ProductRestService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRestService : IProductRestService
    {
        public List<Product> GetProductList()
        {
            return ProductSingleton.Instance.ProductList;
        }
    }
}
