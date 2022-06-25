using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROandVillan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string HeroName = "All Might";
            int heroPower = 20000;
            

            string villainName = "All For One";
            int villainPower = 1000;


            if (heroPower < villainPower)
            {
                Console.WriteLine(" villan will try to increase his power!!! ");


            }// end if 

            else if (heroPower > villainPower)

            {
                Console.WriteLine("The hero is always greater :D !");

            }

            else 
            {

                Console.WriteLine("that's not possible");
            
            }



            }

            }
        }

