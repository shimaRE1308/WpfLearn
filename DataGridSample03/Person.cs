using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridSample03
{
    public enum Gender
    {
        None,
        Men, 
        Women
    }

    public class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool AuthMember { get; set; }
    }
}
