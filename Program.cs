using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{

    internal class Program
    {
        public delegate void SpinDel();
        static void Main(string[] args)
        {
            Spin spin = new Spin();
            int luckyNumber;
            string name;

            SpinDel spinDel = new SpinDel(spin.ZeroSpin);
            Console.WriteLine("Enter Your Name:");
            name = Console.ReadLine();
            while (spin.NoOfSpin != 0)
            {
                spin.NoOfSpin--;
                Console.WriteLine("Enter your lucky number between 1 to 10:");
                try
                {
                    luckyNumber = int.Parse(Console.ReadLine());
                    if(luckyNumber <1 || luckyNumber>10) {
                        Console.WriteLine("Invalid input");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    luckyNumber = 0;
                    Console.WriteLine("Error! " + ex.Message);
                }

                switch (luckyNumber)
                {
                    case 1:
                        {
                            spinDel += new SpinDel(spin.FirstSpin);
                            break;
                        }
                    case 2:
                        {
                            spinDel += new SpinDel(spin.SecondSpin);
                            break;
                        }
                    case 3:
                        {
                            spinDel += new SpinDel(spin.ThirdSpin);
                            break;
                        }
                    case 4:
                        {
                            spinDel += new SpinDel(spin.FourthSpin);
                            break;
                        }
                    case 5:
                        {
                            spinDel += new SpinDel(spin.FifthSpin);
                            break;
                        }
                    case 6:
                        {
                            spinDel += new SpinDel(spin.SixthSpin);
                            break;
                        }
                    case 7:
                        {
                            spinDel += new SpinDel(spin.SeventhSpin);
                            break;
                        }
                    case 8:
                        {
                            spinDel += new SpinDel(spin.EighthSpin);
                            break;
                        }
                    case 9:
                        {
                            spinDel += new SpinDel(spin.NinthSpin);
                            break;
                        }
                    case 10:
                        {
                            spinDel += new SpinDel(spin.TenthSpin);
                            break;
                        }
                    

                }
            }
            Console.WriteLine("Your Result: ");
            spinDel();
            if (spin.Energy >= 4 && spin.WProb > 60)
            {
                Console.WriteLine($"**** Congats! {name} You are Winner! ****");
            }
            else if (spin.Energy >= 1 && spin.WProb > 50)
            {
                Console.WriteLine($"**** {name} You are Runner-Up! ****");
            }
            else
            {
                Console.WriteLine($"**** {name} You are Loser!!! ***");
            }
            Console.ReadKey();
        }
    }
}