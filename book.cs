using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace п2
{
    internal class book
    {
        public int number { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string publisher { get; set; }
        public string type { get; set; }

        public book(int number_, string author_, string title_, int year_, string publisher_, string type_)
        {
            number = number_;

            author = author_;

            title = title_;

            year = year_;

            publisher = publisher_;

            type = type_;

        }
        public string getInfoString() //информация о книге ввиде строки
        {

            return "Автор: " + author + "\nНазвание: " + title + "\nГод издания: " + year + "\nИздательство:" + publisher + "\nЖанр: " + type ;

        }

        public const string separator = "|";
        public string getStringForFile() //для записи в файл
        {

            return author + separator + title + separator + year + separator + publisher + separator + type + separator;

        }
    }
}
