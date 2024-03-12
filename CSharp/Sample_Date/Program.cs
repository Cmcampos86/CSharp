using System.Globalization;

namespace Sample_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method intentionally left empty.
        }

        #region Timespan

        public static void TimeSpan()
        {
            var time = "00:97:54".Split(':');
            Console.WriteLine(new TimeSpan(int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2])));
        }

        #endregion

        #region TryParse

        public static void TryParse()
        {
            string date = "2017-11-23";
            bool resulDate = false;
            DateTime dateConvert = DateTime.MinValue;

            resulDate = DateTime.TryParse(date, out dateConvert);

            Console.WriteLine(dateConvert);
        }

        #endregion

        #region TryParseExact

        public static void TryParseExact()
        {
            string date = "20171123";
            bool resulDate = false;
            DateTime dateConvert = DateTime.MinValue;

            resulDate = DateTime.TryParseExact(date, "yyyyMMdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateConvert);

            Console.WriteLine(dateConvert);
        }

        #endregion

        #region ParseExact

        public static void ParseExact()
        {
            string date = "1/11/2018 4:46:10 PM";
            //string date = "1/11/2018 4:46:10";

            CultureInfo culturaAmericana = new CultureInfo("en-US");
            DateTime dataHora = DateTime.Parse(date, culturaAmericana);

            string dataFormatada = dataHora.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine(dataFormatada);
        }

        #endregion

        #region DateOnly

        public static void DateOnly()
        {
            //DateOnly someDate = new DateOnly(2024, 3, 12);
            //var somenteData = DateOnly.
        }

        #endregion

    }
}
