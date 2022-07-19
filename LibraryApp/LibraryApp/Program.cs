
using LibraryApp.Controllers;
using Service.Helpers;
using Service.Services;
using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService libraryService = new LibraryService();

            BookController bookController = new BookController();

            LibraryController libraryController = new LibraryController();

            Helper.WriteConsole(ConsoleColor.Blue, "Select one option");

            GetMenues();
           

            while (true)
            {
                SelectOption: string selectOption = Console.ReadLine();

                int selecetTrueOption;

                bool isSelectOption = int.TryParse(selectOption, out selecetTrueOption);

                if (isSelectOption)
                {
                    switch (selecetTrueOption)
                    {
                        case (int)Menues.CreateLibrary :

                            libraryController.Create();

                            break;

                        case (int)Menues.GetLibraryById:

                            libraryController.GetById();

                            break;

                        case (int)Menues.UpdateLibrary:

                            libraryController.Update();

                            break;

                        case (int)Menues.DeleteLibrary:

                            libraryController.Delete();

                            break;

                        case (int)Menues.GetAllLibraries:

                            libraryController.GetAll();

                            break;
                        case (int)Menues.SearchLibrary:

                            break;

                            libraryController.Search();

                        case (int)Menues.CreateBook:

                            bookController.Create();

                            break;
                        default:
                            Helper.WriteConsole(ConsoleColor.Red, "Select correct option number");
                            break;
                    }
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Select correct option");
                    goto SelectOption;
                }
            }

            
        }

        private static void GetMenues()
        {
            Helper.WriteConsole(ConsoleColor.Yellow, "1 - Create library, 2 - Get library by Id, 3 - Update library, 4 - Delete library, " +
                " 5 - Get all libraries, 6 - Search for library by name, 7 - Create book ");
        }
    }
}
