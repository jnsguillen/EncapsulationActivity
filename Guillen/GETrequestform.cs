using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guillen
{
    class GETrequestform
    {
        private string EmployeeName;
        private int EmployeeAge;
        private string EmployeeAddress;


        public string Name
        {

            get
            {
                return EmployeeName;
            }
            set
            {
                EmployeeName = value;
            }
        }

        public int Age
        {

            get
            {
                return EmployeeAge;
            }
            set
            {
                EmployeeAge = value;
            }
        }

        public string Address
        {
            get
            {
                return EmployeeAddress;
            }
            set
            {
                EmployeeAddress = value;
            }
        }
    }
}
