using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guillen
{
    class Program
    {
        static void Main(string[] args)
        {

				Console.WriteLine("----------------------------------------");
				Console.WriteLine("EMPLOYEE LEAVES MANAGEMENT SYSTEM");
				Console.WriteLine("----------------------------------------");
				var CurrentDate = DateTime.Now;
				Console.WriteLine(CurrentDate);
				Console.WriteLine("Welcome User!");


				int menu;
				Console.WriteLine("Type the number of which you wish to access: ");
				Console.WriteLine("----------------------------------------------");
				Console.WriteLine("\n1: Request Form \n2: Pending Requests \n3: Record of Leaves");
				menu = Convert.ToInt32(Console.ReadLine());

				REQFORM request = new REQFORM();

				switch (menu)
				{
					case 1:
						request.inputRequest();
						break;


					case 2:
					Console.WriteLine("Pending Requests:");
						break;

					case 3:
					Console.WriteLine("Record of Leaves:");
						break;

					default:
						Console.WriteLine("No match found");
						break;
				}

			}
		}
    }
