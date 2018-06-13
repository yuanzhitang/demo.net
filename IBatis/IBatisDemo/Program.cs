using IBatisDemo.Domain;
using IBatisNet.DataMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBatusDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ISqlMapper mapper = Mapper.Instance();
            IList<SY_Staff> staffs = mapper.QueryForList<SY_Staff>("GetAllStaffs", null);
            Console.WriteLine(staffs.Count);
            Console.ReadLine();
        }
    }
}
