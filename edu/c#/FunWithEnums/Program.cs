using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    class Program
    {
        enum EmpType : short
        {
            Manager = 10,       //=0, если задать значение 200, то след значения будут 200+1
            Grunt = 1 ,         //=1, 201
            Contractor = 100,    //=2, 202
            VicePresident =255  //=3, 203
        }
        static void Main()
        {
            Console.WriteLine("**** Fun with Enums *****");
            // Создать переменную типа ЕmрТуре.
            EmpType еmр = EmpType.Manager;
            AskForBonus(еmр);
            // Вывести тип хранилища для значений перечисления.
            Console.WriteLine("ЕmрТуре uses а {0} for storage", Enum.GetUnderlyingType(еmр.GetType()));
            Console.WriteLine("EmpType uses a {0} for storage",Enum.GetUnderlyingType(typeof(EmpType)));
            // Выводит строку "emp is a Contractor".
            Console.WriteLine("emp is a {0}.", еmр.ToString());
            // Выводит строку "Contractor = 100".
            Console.WriteLine("{0} = {1}", еmр.ToString(), (byte)еmр);
            EvaluateEnum(еmр);

            EmpType e2 = EmpType.Contractor;
            //работа с типами перечислений пространсва имен System
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(cc);
            EvaluateEnum(day);
            EvaluateEnum(e2);
            Console.ReadLine();
        }
        // Перечисления как параметры,
        static void AskForBonus(EmpType е)
        {
            switch (е)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    //He желаете ли взамен фондовые опционы?
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    // Вы должно быть шутите. . .
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    // Вы уже получаете вполне достаточно...
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    // Очень хорошо, сэр!
                    break;
            }
        }
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("\n=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",Enum.GetUnderlyingType(e.GetType()));
            // Получить все пары "имя-значение" для входного параметра.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Вывести строковое имя и ассоциированное значение,
            // используя флаг формата D (см. главу 3).            
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name : {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
