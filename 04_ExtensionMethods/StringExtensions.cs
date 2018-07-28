using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExtensionMethods
{
    public static class StringExtensions
    {
        public static string FirstToUpper(this String str)
        {
            string primeira = str.Substring(0, 1);
            
            string segunda = str.Substring(1);

            return primeira.ToUpper()+segunda;
        }
    }
}
