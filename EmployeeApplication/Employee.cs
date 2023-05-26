using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class Employee
    {
        private int empid;
        private string lastname;
        private string firstname;
        private string position;


        public Employee()
        {
            this.empid = 0;
            this.lastname = null;
            this.firstname = null;
            this.position = null;    

        }


        public Employee(string lname, string fname, string pos)
        {
            this.empid = 0;
            this.lastname = lname;
            this.firstname = fname;
            this.position = pos;

        }

        public int emid
        {
            get
            {
                return this.empid;

            }
            set
            {
                this.empid = value;
            }

        }

        public string emplname
        {
            get
            {
                return this.lastname;
            }
            set
            {
                this.lastname = value;
            }
        }
        public string empfname
        {
            get
            {
                return this.firstname;
            }
            set
            {
                this.firstname = value;
            }

        }
       

    public string emppos
        {
            get
            {
                return this.position;

            }
            set
            {
                this.position = value;
            }
        }


    }


}
