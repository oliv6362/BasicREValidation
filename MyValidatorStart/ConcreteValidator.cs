using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyValidator;

namespace MyValidatorStart
{
    public class ConcreteValidator : MyValidatorLibrary
    {

        public ConcreteValidator(string NAME, string SIRNAME, string STREET ) : base (NAME, SIRNAME, STREET, 0, 0, "", "", "")
        {
          
        }

        protected override void ValidatorExecute()
        {
        }

        public static string pattern = @"\b[M]\w+";
        Regex rg = new Regex(pattern);
    }
}
