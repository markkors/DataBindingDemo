using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo.Models
{
    public class cPerson
    {

        public cPerson(string f, string l)
        {
            Id = Guid.NewGuid().ToString();
            Firstname = f;
            Lastname = l;

        }

        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
