using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AccountList
    {
        public ArrayList list = new ArrayList();
        public void NewAccount()
        {
            Account acc = new Account();
            acc.Input();
            list.Add(acc);
        }
        public void SaveFile()
        {
            Console.Write("Nhap Ten File Can Save: ");
            string filename = Console.ReadLine();
            FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);
            StreamWriter writer = new StreamWriter(output);
            foreach (Account acc in list)
            {
                writer.WriteLine("{0} , {1}, {2} , {3} ", acc.AccountID1, acc.FirstName1, acc.LastName1, acc.Balance1);
            }
            writer.Close();
            output.Close();


        }
        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();
            list.Clear();
            FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(input);
            string str;
            while((str = reader.ReadLine() )!= null){
                string[] lis = str.Split(',');
                Account acc2 = new Account(int.Parse(lis[0]), lis[1], lis[2], float.Parse(lis[3]));
                list.Add(acc2);
                acc2.Output();
            }
            input.Close();
            reader.Close();
        }
    }
}
    