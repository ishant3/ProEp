using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AndroidApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AndroidApplicationSevice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AndroidApplicationSevice.svc or AndroidApplicationSevice.svc.cs at the Solution Explorer and start debugging.
    public class AndroidApplicationSevice : IAndroidApplicationService
    {
        //    Account myAccount;
        //    RestaurantOrderService()
        //    {

        //        myAccount = new Account()
        //        {
        //            Email = "test@test.com",
        //            Password = "password123."
        //        };
        //    }
        //    public bool Authenticate(string email, string password)
        //    {
        //        if (myAccount.Email == email && myAccount.Password == password)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }

        //    public Account GetAccount(string email, string password)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
        public bool Authenticate(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(string email, string password)
        {
            throw new NotImplementedException();
        }

        //for test

        public HelloWorldData GetHelloData(HelloWorldData helloWorldData)
        {
            if (helloWorldData == null)
            {
                throw new ArgumentNullException("helloWorldData");
            }

            if (helloWorldData.SayHello)
            {
                helloWorldData.Name = String.Format("Hello World to {0}.", helloWorldData.Name);
            }
            return helloWorldData;
        }

        public string SayHelloTo(string name)
        {
            return string.Format("Hello World to you, {0}", name);
        }
    }
}
