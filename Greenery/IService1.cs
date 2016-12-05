using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Greenery;

namespace Greenery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void AddGreeneryData(Greenery greeneryDb);

        [OperationContract]
        List<Greenery> GetAllData();

        //[OperationContract]
        //List<GreeneryDb> ();
    }
}
