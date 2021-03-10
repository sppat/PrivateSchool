using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIndividualProject.AppLogic
{
    static class MenuUtils
    {
        public static void GeneralMenu()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("*     1. Entry Menu     *");
            Console.WriteLine("*     2. Print Menu     *");
            Console.WriteLine("*     3. Exit           *");
            Console.WriteLine("*************************");
        }

        public static void EntryMenu()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*     1. Course Entry                          *");
            Console.WriteLine("*     2. Assignment Entry                      *");
            Console.WriteLine("*     3. Trainer Entry                         *");
            Console.WriteLine("*     4. Student Entry                         *");
            Console.WriteLine("*     5. Add Student to a second course        *");
            Console.WriteLine("************************************************");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("*     1.  Print Course List                        *");
            Console.WriteLine("*     2.  Print Assignment List                    *");
            Console.WriteLine("*     3.  Print Trainer List                       *");
            Console.WriteLine("*     4.  Print Student List                       *");
            Console.WriteLine("*     5.  Print Student Per Course                 *");
            Console.WriteLine("*     6.  Print Trainer Per Course                 *");
            Console.WriteLine("*     7.  Print Assignment Per Course              *");
            Console.WriteLine("*     8.  Print Students In Multiple Courses       *");
            Console.WriteLine("*     9.  Student's Assignments                    *");
            Console.WriteLine("*     10. Students Assignments for a certain week  *");
            Console.WriteLine("****************************************************");
        }

        public static int MenuOption(string menu)
        {
            int option;

            if (menu == "General")
                do
                {
                    Console.Write("Choose an option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                } while (option < 1 || option > 3);
            else if (menu == "Entry")
                do
                {
                    Console.Write("Choose an option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                } while (option < 1 || option > 5);
            else 
                do
                {
                    Console.Write("Choose an option: ");
                    option = Convert.ToInt32(Console.ReadLine());
                } while (option < 1 || option > 10);
            return (option);
        }
    }
}
