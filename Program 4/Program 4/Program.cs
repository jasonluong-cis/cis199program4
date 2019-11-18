//A3196
//Due: December 5, 2017
//CIS 199-01
//This program creates a reusable class, methods that changes objects, and a list that has the objects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating objects
            LibraryBook book1 =
                new LibraryBook("How to Fish", "Fiz O Sea", "Fish Inc.", 2007, 52, true);
            LibraryBook book2 =
                new LibraryBook("Book of Names", "Doctor Lingual", "Dictionary Editors", 2012, 49, false);
            LibraryBook book3 =
                new LibraryBook("Monster Slayer", "Heroic Sam", "Monster Fighters", 2014, 61, false);
            LibraryBook book4 =
                new LibraryBook("How to Lose All Your Money", "Begger Jordan", "Soup Kitchen", 2015, 86, true);
            LibraryBook book5 =
                new LibraryBook("Survival Book", "Caveman Jim", "Brickhouse Inc.", 1993, 42, true);

            //Creating array
            LibraryBook[] books = new LibraryBook[5];

            books[0] = book1;
            books[1] = book2;
            books[2] = book3;
            books[3] = book4;
            books[4] = book5;

            //Displaying List
            void Original()
            {
                foreach (LibraryBook book in books)
                {
                    Console.WriteLine(book);
                    Console.WriteLine();
                }
            }

            //Displaying Altered List
            void Altercation1()
            {
                book1.CheckOut();
                book4.CheckOut();
                foreach (LibraryBook book in books)
                {

                    Console.WriteLine(book);
                    Console.WriteLine();
                }

            }

            //Displaying Original-altered List
            void Altercation2()
            {
                book1.ReturntoShelf();
                book1.ReturntoShelf();
                foreach (LibraryBook book in books)
                {
                    Console.WriteLine(book);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Original");
            Console.WriteLine();
            Original();
            Console.WriteLine();

            Console.WriteLine("First Altercation");
            Console.WriteLine();
            Altercation1();
            Console.WriteLine();

            Console.WriteLine("Second Altercation");
            Console.WriteLine();
            Altercation2();
            Console.WriteLine();

        }
        
    }
}
