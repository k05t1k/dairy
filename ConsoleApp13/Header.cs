using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class C_DataClass
    {
        public int m_iDay = 1;
        public int m_iMonth = 1;
        public int m_iYear = 2023;
    }
    internal class C_Helpers
    {
        public int m_iPos = 1;

        public bool m_bFlag = false;
    }
    internal class C_Tasks
    {
        public static void Task1(C_DataClass dataClass)
        {
            Console.WriteLine($"Сегодня {dataClass.m_iDay}.{dataClass.m_iMonth}.{dataClass.m_iYear} \n");
            Console.WriteLine("-  Ваша задача на день: помыть посуду, тем самым помочь своей маме.");
        }
        public static void Task2(C_DataClass dataClass)
        {
            Console.WriteLine($"Сегодня {dataClass.m_iDay}.{dataClass.m_iMonth}.{dataClass.m_iYear} \n");
            Console.WriteLine("-  Ваша задача на день: пойти в колледж и отсидеть там 5 пар.");
        }
        public static void Task3(C_DataClass dataClass)
        {
            Console.WriteLine($"Сегодня {dataClass.m_iDay}.{dataClass.m_iMonth}.{dataClass.m_iYear} \n");
            Console.WriteLine("-  Ваша задача на день: остаться дома и просидеть весь день в одиночестве.");
        }
        public static void Task4(C_DataClass dataClass)
        {
            Console.WriteLine($"Сегодня {dataClass.m_iDay}.{dataClass.m_iMonth}.{dataClass.m_iYear} \n");
            Console.WriteLine("-  Ваша задача на день: ничего не делать...");
        }
        public static void Task5(C_DataClass dataClass)
        {
            Console.WriteLine($"Сегодня {dataClass.m_iDay}.{dataClass.m_iMonth}.{dataClass.m_iYear} \n");
            Console.WriteLine("-  Ваша задача на день: пойти гулять со своими лучшими друзьями.");
        }
    }
}
