using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramOops
{
    internal class CheckAnagramStrings
    {
        public bool IsAnagram(string str1, string str2)
        {
            str1 = new string(str1.ToLower().Where(char.IsLetterOrDigit).ToArray());
            str2 = new string(str2.ToLower().Where(char.IsLetterOrDigit).ToArray());

            if (str1.Length != str2.Length)
                return false;
            return new string(str1.OrderBy(c => c).ToArray()) == new string(str2.OrderBy(c => c).ToArray());
        }
    }
}
