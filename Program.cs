using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HW_Library
{
    internal class Program
    {

        //творити класс Library. Властивості: ім'я бібліотеки, адрес, список книжок (використовувати створений на
        //практиці клас Book). Реалізувати ітератор.Тест: створити масив книжок, створити об'єкт бібліотекі та
        //перебрати всі книжки, які там є.Використати оператор yield.

        static void Main(string[] args)
        {
            Book book = new Book("Book1" ,"1",1);
            Book book2 = new Book("Book2" ,"2",2);
            Book book3 = new Book("Book3" ,"3",3);

            Book[] arr = new Book[3];
            arr[0] = book;
            arr[1] = book2;
            arr[2] = book3;
            Library library = new Library("Library","adress1",arr);

            
            
            foreach (var  item in library)
            {
                Console.WriteLine($"--------\n{item}\n");
            }

            Console.ReadLine();

        }
    }
}
