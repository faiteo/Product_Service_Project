using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Product_Service_Project
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        //[ServiceKnownType(typeof(Book))]
        //[ServiceKnownType(typeof(CD))]
       
        [OperationContract]
        Product GetProduct(int productID);

    }
}
