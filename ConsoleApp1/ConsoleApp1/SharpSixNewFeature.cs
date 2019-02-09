using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace ConsoleApp1
{
    public class SharpSixNewFeature
    {
        #region Auto-property initializers
        public string Name { get; set; } = "Summit";
        public int Age { get; set; } = 22;
        public DateTime BirthDay { get; set; } = DateTime.Now.AddYears(-20);
        public IList<int> AgeList
        {
            get; set;
        } = new List<int> { 2, 4, 6, 8, 10 };
        #endregion

        #region Expression bodies on property-like function members
        public string NameFormat => string.Format("name: {0}", "submmit");
        public void ShowName() => Console.WriteLine(Name); 
        #endregion

        public void Show()
        {
            #region String interpolation
            Console.WriteLine($"Name :{this.Age}, birthday:{this.BirthDay.ToString("yyyy-MM-dd")} ");
            Console.WriteLine($"Name :{{{this.Age}}}, birthday:{{{this.BirthDay.ToString("yyyy-MM-dd")}}} ");
            Console.WriteLine($"This is a {(this.Age<=16?"Child":"Adult")}");
            #endregion

            //Using the method of a static class directly
            Console.WriteLine($"4^2 = {Pow(4,2)}");

            #region Null conditional operators
            int? iValue = 10;
            Console.WriteLine(iValue?.ToString());
            string name = null;
            Console.WriteLine((name?.ToString()));
            #endregion

            #region Index initializers
            IDictionary<int, string> dicOld = new Dictionary<int, string>
            {
                { 1,"first  "},
                { 2,"second  "}
            };

            IDictionary<int, string> dicNew = new Dictionary<int, string>
            {
                [1] = "first",
                [2] = "second"
            };
            #endregion

            #region Exception filters
            int exceptionValue = 10;
            try
            {
                Int32.Parse("s");
            }
            catch (Exception e) when (exceptionValue > 1) //Only throw exception when exceptionValue greater than 1
            {
                Console.WriteLine(e);
            }
            #endregion

            #region Nameof Expression
            People people = new People();
            var x = people;
            Console.WriteLine(nameof(x));
            Console.Read();
            #endregion
            //await people.Get();
        }
     }
}
