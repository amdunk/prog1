using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Proj1
{
    public class Program
    {

        private static int readSize = 65536;

        public static void Main(string[] args)
        {
            var starttime = DateTime.Now;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var fin = new StreamReader(new FileStream("big.txt", FileMode.Open), Encoding.UTF8);
            String pre = "";
            var buffer = new char[readSize];
            int size;
            var result = new Dictionary<string , ulong>();
            while (true)
            {
                size = fin.ReadBlock(buffer, 0, readSize);
                if (size < readSize)
                {
                    var buffer1 = new char[size];
                    Array.Copy(buffer, 0, buffer1, 0, size);
                    buffer = buffer1;
                }

                var s = pre + new String(buffer);
                var line = (pre + new String(buffer)).Split(';');
                var length = line.Length;
                if ( size < readSize || buffer[readSize - 1] == ';' )
                {
                    pre = "";
                }
                else
                {
                    length--;
                    pre = line[line.Length - 1];
                }
                for (int i = 0; i < length; i++)
                {
                    if (result.ContainsKey(line[i]))
                    {
                        result[line[i]]++;
                    }
                    else
                    {
                        result.Add(line[i], 1);
                    }
                }
                if (size < readSize)
                {
                    break;
                }
            }
            var mm = from x in result
                     orderby x.Value descending
                     select new { value = x.Key, count = x.Value };
            foreach (var item in mm)
            {
                Console.WriteLine("'{0}'\t'{1}'", item.count, item.value);
            }
            System.Console.ReadKey();
            Console.WriteLine(DateTime.Now - starttime);
        }
    }
}
