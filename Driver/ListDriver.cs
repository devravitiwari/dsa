using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.List;
namespace Driver
{
    class ListDriver
    {
        public static void TestList()
        {
            List<int> data = new List<int>();

            for(int i = 0; i < 10; i++)
            {
                data.Add(i);
            }

            data.Print();

            data.Remove(0);
            data.Print();
            data.Remove(3);
            data.Print();
            data.Remove(9);
            data.Print();


        }
    }
}
