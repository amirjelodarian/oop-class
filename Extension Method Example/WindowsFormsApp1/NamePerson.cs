using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class NamePerson
    {
        public static string GetFullName(this Person person)
        {
            return $"{person.Name} - {person.Family}";
        }
    }
}
