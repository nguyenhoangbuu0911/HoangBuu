using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViTri_LonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tim gia tri lon nhat cua cac phan tu: ");
            int[] a = new int[100];
            Console.Write("Nhap phan tu cho mang: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Nhap phan tu thu {0} la: ", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            int max = Int32.MinValue;
            for(int i = 1; i <= n; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Gia tri lon nhat cua mang la {0}: ", max);
            Console.ReadKey();
        }
    }
}
