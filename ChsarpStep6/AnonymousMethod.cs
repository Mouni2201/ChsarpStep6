using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace AnonymousMethod
{
    delegate void RestaurantTask(string taskDetail);
    //Method doesn't  have the name is Anonymous
    //use delegates to develop the anonymous  Methods
    class Program
    {
        static void Main()
        {
            //delegate (string orderName)  method without name
            // Anonymous method for taking orders
            RestaurantTask takeOrder = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Taking order for " + orderName);
            };

            // Anonymous method for preparing food
            RestaurantTask prepareFood = delegate (string orderName)
            {
                Console.WriteLine("Kitchen: Preparing " + orderName);
            };

            // Anonymous method for serving food
            RestaurantTask serveFood = delegate (string orderName)
            {
                Console.WriteLine("Waiter: Serving " + orderName);
            };
            string order = "Pista";
            takeOrder(order);
            prepareFood(order);
            serveFood(order);


        }
    }
}
