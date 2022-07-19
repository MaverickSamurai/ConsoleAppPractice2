using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.Controllers
{
   public class BookController
    {
        BookService bookService = new BookService();
        public void Create()
        {
            Helper.WriteConsole(ConsoleColor.Blue, "Add library id : ");

            LibraryId: string libraryId = Console.ReadLine();

            int selectedLibraryId;

            bool isSelectedLibraryId = int.TryParse(libraryId, out selectedLibraryId);

            if (isSelectedLibraryId)
            {
                Helper.WriteConsole(ConsoleColor.Blue, "Add book name : ");
                string bookName = Console.ReadLine();

                Helper.WriteConsole(ConsoleColor.Blue, "Add book author : ");
                string author = Console.ReadLine();

                Book book = new Book()
                {
                    Name = bookName,
                    Author = author
                };

                var result = bookService.Create(selectedLibraryId, book);

                if(result != null)
                {
                    Helper.WriteConsole(ConsoleColor.Green, $"Library Id : {result.Id}, Name : {result.Name}, Author : {result.Author}, Book library name : {result.Library.Name} ");
                }
                else
                {
                    Helper.WriteConsole(ConsoleColor.Red, "Library not found, please add correct library id : ");
                    goto LibraryId;
                }
            }
         
            else
            {
                Helper.WriteConsole(ConsoleColor.Red, "Add correct library id type : ");
                goto LibraryId;
            }

            

            
        }
    }
}
