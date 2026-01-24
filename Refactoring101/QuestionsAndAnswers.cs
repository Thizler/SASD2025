using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring101
{
    // Do Refactoring the following code:
    public class QuestionsAndAnswers
    {
        // 1. Mysterious Name
        public double GetMax(double a, double b)
        {
            return a > b ? a : b;
        }

        // 2. Duplicate Code
        public void Print()
        {
            PrintName("Mr.Harry Potter");
            PrintName("Ms.Mary Poppin");
            PrintName("Mr.Johny Black");
        }
        private void PrintName(string name)
        {
            Console.WriteLine("***********************");
            Console.WriteLine($"   {name}");
            Console.WriteLine("***********************");
            Console.WriteLine();
        }

        // 3. Shotgun Surgery
        public class Constant
        {
            public const int Student = +48;
        }
        public class Shotgun1
        {
            public void DisplayStudents()
            {
                Console.WriteLine("Student Count = " + Constant.Student);
            }
        }
        public class Shotgun2
        {
            public void PrintTotal()
            {
                Console.WriteLine("Total Students : " + Constant.Student);
            }
        }

        // 4. Data Clump
        public class MyDate
        {
            public int Day { get; }
            public int Month { get; }
            public int Year { get; }

            public MyDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public string Format()
            {
                return $"{Day:00}/{Month:00}/{Year:0000}";
            }
        }

        // 5. Feature Envy
        //     จากข้อที่แล้ว น่าจะได้สร้างคลาส Date ขึ้นมา
        //     ในคลาส Date นั้นให้สร้าง method: public string Format()
        //      ปรับให้ PrintDate(...) ของเดิม ไปเรียก date.Format() ดังกล่าว
        public void PrintDate(MyDate date)
        {
            Console.WriteLine(date.Format());
        }
    }
}
