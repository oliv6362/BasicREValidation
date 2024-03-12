using System.Text.RegularExpressions;

namespace MyValidator
{
    public abstract class MyValidatorLibrary
    {

        //properties
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string STREET { get; set; }
        public int NUMBER { get; set; }
        public int POSTALZIP { get; set; }
        public string POSTALCITY { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }


        protected MyValidatorLibrary(string name, string surname, string street, int number, int postalzip, string postalcity, string phone, string email)
        {
            NAME = name;
            SURNAME = surname;
            STREET = street;
            NUMBER = number;
            POSTALZIP = postalzip;
            POSTALCITY = postalcity;
            PHONE = phone;
            EMAIL = email;
        }


        public void Start() 
        {
            List<bool> IsStringsValid = ValidateStrings(NAME, SURNAME, STREET, POSTALCITY);
            Console.WriteLine(IsStringsValid[0]);
            Console.WriteLine(IsStringsValid[1]);
            Console.WriteLine(IsStringsValid[2]);
            Console.WriteLine(IsStringsValid[3]);

          



        }



        private static List<bool> ValidateStrings(string NAME, string SURNAME, string STREET, string POSTALCITY)
        {
            string pattern = @"^\D+$";
            Regex rg = new Regex(pattern);
          
            List<bool> list = new List<bool>();
            list.Add(rg.IsMatch(NAME));
            list.Add(rg.IsMatch(SURNAME));
            list.Add(rg.IsMatch(STREET));
            list.Add(rg.IsMatch(POSTALCITY));

            return list;
        }

     


        public static bool Validate(string input)
        {
            string pattern = @"hello1";
            Regex rg = new Regex(pattern);
            return rg.IsMatch(input);
        }

        protected abstract void ValidatorExecute();

    }
}   
