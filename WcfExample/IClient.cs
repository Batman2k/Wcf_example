using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfExample.Models;

namespace WcfExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClient" in both code and config file together.
    [ServiceContract]
    public interface IClient
    {
        [OperationContract]
        IEnumerable<User> ReturnAllCleanersByCity(string city);

        [OperationContract]
        User CreateUser(User user);

        //[OperationContract]
        //Company CreateCompany(Company company, string userName, string password);
        

        // Do manualy for saftey?
        //[OperationContract]
        //Company GetCompanDataCompany(string companyName);
      








        }
}
