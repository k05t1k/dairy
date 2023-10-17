using static ConsoleApp13.C_DataClass;
using static ConsoleApp13.C_Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // это чтоба передавать в функи ага
            C_DataClass dataClass = new C_DataClass();
            C_Helpers helper = new C_Helpers();

            // ага прям сюда
            Dairy(dataClass, helper);
        }
        // warning! говнокод
        static void VariationOfAction(C_DataClass data, C_Helpers helper)
        {
            if (data.m_iDay % 2 == 0)
            {
                switch(helper.m_bFlag)
                {
                    case true:
                        Console.WriteLine("     Помыть посуду");
                        Console.WriteLine("     Пойти в колледж");
                        Console.WriteLine("     Остаться дома");
                        break;
                    case false:
                        Console.WriteLine("     Остаться дома");
                        Console.WriteLine("     Ничего не делать");
                        Console.WriteLine("     Пойти гулять");
                        break;
                }
            }
            else
            {
                Console.WriteLine("     Сегодня ничего не нужно делать :)");
            }
        }
        static void Select(C_DataClass data, C_Helpers helper, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                // down & up keys
                case ConsoleKey.UpArrow:
                    if (helper.m_iPos != 1)
                    {
                        Console.Clear();
                        helper.m_iPos--;
                    }
                    else
                        Console.Clear();
                    break;
                case ConsoleKey.DownArrow:
                    if (helper.m_iPos != 3)
                    {
                        Console.Clear();
                        helper.m_iPos++;
                    }
                    else
                        Console.Clear();
                    break;
                // left & right keys
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    data.m_iDay--;
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    data.m_iDay++;
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        static void DataNormalize(C_DataClass dataClass)
        {
            if (dataClass.m_iDay <= 0)
            {
                dataClass.m_iDay = 30;
                dataClass.m_iMonth--;
                if (dataClass.m_iMonth <= 0)
                {
                    dataClass.m_iYear--;
                    dataClass.m_iMonth = 30;
                }
            }
            else if (dataClass.m_iDay > 31)
            {
                dataClass.m_iDay = 1;
                dataClass.m_iMonth++;
                if (dataClass.m_iMonth >= 12)
                {
                    dataClass.m_iMonth = 1;
                    dataClass.m_iYear++;
                }
            }
        }
        // вы бы знали насколько мне стыдно..
        static void VariationOfTasks(C_DataClass dataClass, C_Helpers helper)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                if (dataClass.m_iDay % 2 == 0)
                {
                    if (helper.m_bFlag)
                        switch (helper.m_iPos)
                        {
                            case 1:
                                Task1(dataClass);
                                break;
                            case 2:
                                Task2(dataClass);
                                break;
                            case 3:
                                Task3(dataClass);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                    else
                        switch (helper.m_iPos)
                        {
                            case 1:
                                Task3(dataClass);
                                break;
                            case 2:
                                Task4(dataClass);
                                break;
                            case 3: 
                                Task5(dataClass);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                }

                keyInfo = Console.ReadKey();
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            Console.Clear();
            Dairy(dataClass, helper);
        }
        static void Dairy(C_DataClass data, C_Helpers helper)
        {
            // чоооооооооо
            ConsoleKeyInfo key;
            
            while (true) 
            {
                // ну чтоба типа ну как сказать блин)) )ну типа чтобы не было 32.13.9999
                DataNormalize(data);

                Console.WriteLine($"Сегодня { data.m_iDay }.{ data.m_iMonth }.{ data.m_iYear }");

                // вариации заданий кароч
                VariationOfAction(data, helper);

                // render of ->
                Console.SetCursorPosition(0, helper.m_iPos);
                Console.WriteLine("->");
                key = Console.ReadKey();
                Console.SetCursorPosition(0, helper.m_iPos);
                Console.WriteLine("  ");

                // наговнякал о___0
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                {
                    if (data.m_iDay % 2 == 0)
                    {
                        if (helper.m_bFlag)
                            helper.m_bFlag = false;
                        else
                            helper.m_bFlag = true;
                    }
                }

                // select of ->
                Select(data, helper, key);

                if (key.Key == ConsoleKey.Enter && data.m_iDay % 2 == 0)
                {
                    Console.Clear();
                    break;
                }
            }

            // чооо таски эта чо
            VariationOfTasks(data, helper);
        }
    }
}