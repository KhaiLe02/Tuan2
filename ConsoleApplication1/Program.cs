using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1

{
    class main
    {
        static void Main(string[] args)
        {
            AccountList listmain = new AccountList();
            byte chon;
            do
            {
                Console.WriteLine("1. ADD");
                Console.WriteLine("2. Save");
                Console.WriteLine("3. Load");
                Console.WriteLine("0. Exit");

                Console.Write("Nhap: ");
                chon = byte.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        listmain.NewAccount();
                        break;
                    case 2:
                        listmain.SaveFile();
                        break;
                    case 3:
                        listmain.LoadFile();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Khong co chuc nang nay !!!!!!");
                        break;

                }
            } while (chon != 0);
        }
    }
}
