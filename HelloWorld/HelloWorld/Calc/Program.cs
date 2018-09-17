using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> outList = new List<List<int>>();

            int maxDistance = 20;

            List<List<int>> fwdMatrix = new List<List<int>>()
                {
                    new List<int>() { 1, 8 },
                    new List<int>() { 2, 5 },
                    new List<int>() { 3, 14 }
                };

            List<List<int>> returnMatrix = new List<List<int>>()
                {
                    new List<int>() { 1, 5 },
                    new List<int>() { 2, 7 },
                    new List<int>() { 3, 14 }
                };

            var output = (from a in fwdMatrix
                           from b in returnMatrix
                           where a[1] + b[1] < maxDistance
                              orderby a[1] + b[1] descending
                              select new { a = a[0], b = b[0], total = a[1] + b[1] }).ToList();

            foreach (var n in output.Where(x => x.total == output.Max(y => y.total)).ToList())
            {
                outList.Add(new List<int>() { n.a, n.b });
                Console.WriteLine("{0},{1}", n.a, n.b);
            }

            Console.ReadKey();
        }
    }
}
