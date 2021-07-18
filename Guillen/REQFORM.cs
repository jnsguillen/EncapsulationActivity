using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guillen
{
    public class REQFORM
    {
        public void inputRequest()
        {
            GETrequestform gtst = new GETrequestform();

            Console.WriteLine("To file a Leave Request, kindly answer the following: ");

            string ename;
            Console.WriteLine("Name: ");
            ename = Console.ReadLine();
            gtst.Name = ename;

            int eage;
            Console.WriteLine("Age: ");
            eage = Convert.ToInt32(Console.ReadLine());
            gtst.Age = eage;

            string eaddress;
            Console.WriteLine("Address: ");
            eaddress = Console.ReadLine();
            gtst.Address = eaddress;

            int TypeofLeave;
            Console.Write("Choose which type of leave you will request: ");
            Console.WriteLine("\n1: Vacation \n2. Sick Leave \n3: Unpaid Leave \n4: Work from home");
            TypeofLeave = Convert.ToInt32(Console.ReadLine());
        }
    }
}

