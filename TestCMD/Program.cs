using Common;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnPageResult<ApiSeatsAndEmpsModel> str = AppWebService.BaseAPI.GetSeatsAndMembers( "31");
            foreach (var item in str.Data1.Members)
            {
                Console.WriteLine(item.OID);
                Console.WriteLine(item.Cname);
            }
            Console.ReadLine();
        }
    }
}
