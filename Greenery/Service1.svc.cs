using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Greenery;

namespace Greenery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        GreeneryEntityModel em = new GreeneryEntityModel();

        public void AddGreeneryData(Greenery greenery)
        {
            em.Greeneries.Add(greenery);
            em.SaveChanges();
        }

        public List<Greenery> GetAllData()
        {
            return em.Greeneries.ToList();
        }
    }
}
