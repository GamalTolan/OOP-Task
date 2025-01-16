using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task
{
    public class Library_Item
    {
        public int ItemId { get; set; }
        public bool Isavailable { get; set; }

        public Library_Item(int itemId)
        {
            ItemId = itemId;
            Isavailable = true;
        }

        public void CheckOut()
        {
            if (Isavailable)
            {
                Isavailable = false;
                Console.WriteLine("The item has been checked out.");
            }
            else
            {
                Console.WriteLine("The item is already checked out.");
            }
        }

        public void ReturnItem()
        {
            if (!Isavailable)
            {
                Isavailable = true;
                Console.WriteLine("The item has been returned.");
            }

        }

    }
}

