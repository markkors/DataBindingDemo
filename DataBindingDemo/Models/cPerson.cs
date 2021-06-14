using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo.Models
{
    class cPerson
    {

        public cPerson(string f, string l)
        {
            Firstname = f;
            Lastname = l;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
