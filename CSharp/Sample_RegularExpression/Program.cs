using System.Text.RegularExpressions;

namespace Sample_RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region RegexQualquer

        public static void RegexQualquer()
        {
            var str = "Plano Liberty Empresa +50 - 047-99660-2224(058/PÓS/SMP)";

            Match match = Regex.Match(str, @"(\d{3}-\d{5}-\d{4})");
            Console.WriteLine(match.Groups[1].Value);
        }

        #endregion

        #region RegexExato

        public static void RegexExato()
        {
            string[] numbers =
            {
                "123-55555-0190",
                "444-234-22450",
                "690-555-0178",
                "146-893-232",
                "146-555-0122",
                "4007-555-0111",
                "407-555-0111",
                "407-2-5555",
                "047-99660-2224"
            };

            string sPattern = "^\\d{3}-\\d{5}-\\d{4}$";

            foreach (string s in numbers)
            {
                Console.Write("{0,14}", s);

                if (Regex.IsMatch(s, sPattern))
                    Console.WriteLine(" - valid");
                else
                    Console.WriteLine(" - invalid");
            }
        }

        #endregion
    }
}
