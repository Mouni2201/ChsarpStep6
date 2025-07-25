using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithReturns
{
    public class Hospital
    {
        public string PrepareforSurgery(string order)
        {
            return $"The doctor preapring the surgery with Surgical scissors";
        }
        public void JoiningDateForSurgery(int date)
        {
            Console.WriteLine($"The patient needs to join the mentioned date: {date}");
        }
        //check if order is available using foreachloop
        public bool ChecktheAvailablity(string order)
        {
            Console.WriteLine(
        }
        
    }
}
