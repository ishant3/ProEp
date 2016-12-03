using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AndroidApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAndroidApplicationService
    {
        // TODO: Add your service operations here
        [OperationContract]
        bool Authenticate(string email, string password);
        [OperationContract]
        Account GetAccount(string email, string password);

        //for test
        [OperationContract]
        string SayHelloTo(string name);

        [OperationContract]
        HelloWorldData GetHelloData(HelloWorldData helloWorldData);

    }

    //for test
    [DataContract]
    public class HelloWorldData
    {
        public HelloWorldData()
        {
            Name = "Hello ";
            SayHello = false;
        }

        [DataMember]
        public bool SayHello { get; set; }

        [DataMember]
        public string Name { get; set; }
    }



    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "RestaurantOrder.ContractType".
    [DataContract]
    public class MenuProduct
    {
        [DataMember]
        public int Productid { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string Productdescription { get; set; }
        [DataMember]
        public decimal ProductPrice { get; set; }
        [DataMember]
        public int Quantity { get; set; }
    }
    [DataContract]
    public class Account
    {
        [DataMember]
        public int Accountid { get; set; }
        [DataMember]
      public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
     


    }
    [DataContract]
    public class Restaurant
    {
        [DataMember]
        public int Restaurantid { get; set; }
        [DataMember]
        public string Restaurantname { get; set; }
        [DataMember]
        public string Location { get; set; }
        [DataMember]
        public int nbrOfTables { get; set; }
        
    }
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Orderid { get; set; }
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public int Accountid { get; set; }
        [DataMember]
        public int Restaurantid { get; set; }
        [DataMember]
        public int TableNbr { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public List<MenuProduct> orderList { get; set; }

    }
}
