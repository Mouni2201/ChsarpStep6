using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDelegates_void_Example
{
    public delegate void KitchenSection(string order);
    public class Restaurant
    {
        public void MainCourseSection(string order)
        {
            Console.WriteLine($"MainCourse chef is preapring: {order}");
        }
        public void DessertSection(string order)
        {
            Console.WriteLine($"In Dessert Section is preparing: {order}");
        }
        public void DrinkSection(string order)
        {
            Console.WriteLine($"Drinks Section is preparing: {order}");
        }
        
    }

    class ExecuteRestaurant
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            //here waiter acts as delegates that routes order 
            KitchenSection waiter;     //create delegate object not assigned to any object

            Console.WriteLine("customer order Pizza");
            waiter = restaurant.MainCourseSection;
            waiter("Pizza");  //call the delegate
            //here the delgates call the mainCourse section method and passess order as parameter
            //the maincourse method is executed
            //here waiter is delegate that point to mainCourse section method

            Console.WriteLine("\n Customer places order for Ice cream");
            waiter = restaurant.DessertSection;
            waiter("IceCream");

            Console.WriteLine("\n Customer places order for Mojito");
            waiter = restaurant.DrinkSection;
            waiter("Mojito");



        }
    }
}
