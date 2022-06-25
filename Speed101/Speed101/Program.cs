using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float playerSpeed = 2.7f;

            void SetSpeed(float x)
            {
                Console.WriteLine(playerSpeed);

                playerSpeed = x;

                Console.WriteLine(playerSpeed);

            }

            SetSpeed(2.5f);

            
            void CompareSpeed(float old,float new2)

            { 

                if(old > new2)

                {
                    Console.WriteLine(old);

                }

                else if (new2>old)
                {
                    Console.WriteLine(new2);

                }

            }
            CompareSpeed(2.7f, 2.5f);


        }
    }
}
