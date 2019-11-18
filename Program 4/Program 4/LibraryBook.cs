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
    class LibraryBook
    {
        //variables
        private int _copyrightYear; //secondary variable for CopyrightYear
        public string Title { get; set; } //Name
        public string Author { get; set; } //Writer
        public string Publisher { get; set; } //Prints the book
        public int Year { get; set; } //Year
        public bool Status { get; set; } //Available or not
        public int CopyrightYear //Year
        {
            get
            {
                return _copyrightYear;
            }
            set
            {

                if (value >= 0)
                    _copyrightYear = value;
                else
                    value = 2017;
            }
        }
        public int CallNumber { get; set; } //Library #
        //Preconditions: None
        //Postconditions: Makes Status to false meaning unavailable
        public void CheckOut() //Method 
        {
            Status = false;
        }
        //Preconditions:None
        //Postconditions: Makes Status true meaning available
        public void ReturntoShelf()
        {
             Status = true;
        }
        public bool IsCheckedOut()
        {
            if (Status == true)
            {
                return false;
            }
            return true;
        }


        //Constructor
        public LibraryBook(string title, string author, string publisher,
            int copyrightYear, int callNumber, bool status)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            CopyrightYear = copyrightYear;
            CallNumber = callNumber;
            Status = status;
        }

        //return string
        public override string ToString()
        {
            return $"Title: {Title} {Environment.NewLine}" +
                $"Author: {Author} {Environment.NewLine}" +
                $"Publisher: {Publisher} {Environment.NewLine}" +
                $"Copyright Year: {CopyrightYear} {Environment.NewLine}" +
                $"Call Number: {CallNumber} {Environment.NewLine}" +
                $"Available: {Status}";
        }
    }
}
