namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            DateTime newDateTime = dateTime.AddDays(3);

            int comparison = dateTime.CompareTo(newDateTime);
            //date1, date2'den önce ise -1, sonra ise 1, eşit ise 0 döner.


            DateTime date2 = dateTime.AddTicks(1000000);

            DateTime date3 = DateTime.Now;

            bool areEqual = date2.Equals(date3);

            int days = DateTime.DaysInMonth(2024, 2);

            DateTime date4 = DateTime.Now;
            
            DateTime date5 = date4.Kind == DateTimeKind.Utc ? date4 : date4;
            Console.WriteLine(date5.Kind);
            
            
            long binaryDate = DateTime.Now.ToBinary();
            DateTime restoredDate = DateTime.FromBinary(binaryDate);
            Console.WriteLine(binaryDate);

            DateTime date6 = new DateTime(2021, 08, 12);

            double OAdate= date6.ToOADate();
            Console.WriteLine(OAdate);  //30 Aralık 1899'dan itibaren geçen toplam gün sayısıdır.

            DateTime date7 = date4.AddMonths(-10);
            bool isDst = date7.IsDaylightSavingTime();
            Console.WriteLine(isDst);


            










        }
    }
}
