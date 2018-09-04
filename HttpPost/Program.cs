using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpPost
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpPosting httpPosting = new HttpPosting();
            Task<string> task = httpPosting.PostHttpAsync();
            Console.WriteLine(task.Result);
            Console.ReadKey();
        }
    }
}
