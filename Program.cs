using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class program
    {
        public static void Main()
        {

            UC1Add<int> Add = new UC1Add<int>(56);
            Add.Insert(30);
            Add.Insert(70);
            Add.Display();
            Console.ReadLine();

        }

    }
}
