using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegatesWithReturns.Hospital;

namespace DelegatesWithReturns
{
    public class Hospital
    {
        public delegate string Operation(string order);
        public delegate void DateOfJoin(int date);
        public delegate bool Availability(string tool);
        public string PrepareforSurgery(string order)
        {
            return $"The doctor preapring the surgery with Surgical scissors";
        }
        public void JoiningDateForSurgery(int date)
        {
            Console.WriteLine($"The patient needs to join the mentioned date: {date}");
        }
        //check if tool is available using foreachloop
        public bool ChecktheAvailablity(string tool)
        {
            string[] toolName = { "Surgical scissors", "Scalpel", "Forceps", "Retractor" };
            foreach(string tools in toolName)
            {
                if (tools.Equals(tool))
                {
                    return true;
                }

               
            }
            return false;
        
        }
        
    }

    class ExecuteRestaurant
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            //regestration methods along with delegates
            Operation patientdelegate = hospital.PrepareforSurgery;
            DateOfJoin patientConfirmationDelegates = hospital.JoiningDateForSurgery;
            Availability availabilitydeligates = hospital.ChecktheAvailablity;

            Console.Write("Enter the surgical tool name: ");
            string order = Console.ReadLine();

            bool isAvailable = availabilitydeligates(order);
            if (isAvailable)
            {
                string message = patientdelegate(order);
                Console.WriteLine(message);

                // Call joining date
                patientConfirmationDelegates(28); // example date

            }
            else
            {
                Console.WriteLine($"The tool \"{order}\" is not available for surgery.");
            }
            Console.ReadLine();
        }

        
    }
}
