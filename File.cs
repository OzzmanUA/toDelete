using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class File
    {
        public string Name { get; set; }
        public string Extantion { get; set; }
        public long Size { get; set; }
        public DateTime Creation { get; set; }
        public File()
        {
            Name = "Example";
            Extantion = "txt";
            Size = 1;
            Creation = DateTime.Now;
        }
        public File(string name, string extantion, long size, DateTime creation)
        {
            Name = name;
            Extantion = extantion;
            Size = size;
            Creation = creation;
        }
        public string FileSize()
        {
            if (Size < 1024) return Size.ToString() + "byte";
            else
            {
                if ((Size / 1024) < 1024) return (Size / 1024).ToString() + "." + ReturnTwoNumbers(Size % 1024).ToString() + "kb";
                else
                {
                    if ((Size / 1048576) < 1024) return (Size / 1048576).ToString() + "." + ReturnTwoNumbers(Size % 1048576).ToString() + "mb";
                    else return (Size / 1073741824).ToString() + "." + ReturnTwoNumbers(Size % 1073741824).ToString() + "gb";

                }
            }
        }
        public void Print()
        {
            Console.Write($"File: {Name}.{Extantion}    Created: {Creation.Day}.{Creation.Month}.{Creation.Year}     Size: ");
            Console.WriteLine(FileSize());
        }
        long ReturnTwoNumbers(long number)
        {
            int[] arr = new int[9] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            if (number < 100)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == number) number /= 10;
                }
                return number;
            }
            else
            {
                while (number > 100) number /= 10;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == number) number /= 10;
                }
                return number;
            }
        }
    }
}
