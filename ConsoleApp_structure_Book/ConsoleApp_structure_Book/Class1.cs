using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_structure_Book
{
     public struct BOOK
    {
        private string _title;
        private int _id;
        private double _cost;
        public int bookID { 
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
        public double price
        {
            get
            {
                return this._cost;
            }
            set
            {
                this._cost = value;
            }
        }
        public enum bookType
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }

    }
}
