using Spring.Context;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IUserInfoDal efDal = ctx.GetObject("UserInfoDal") as IUserInfoDal;
            efDal.Show();

            IUserInfoDal adoDal = ctx.GetObject("UserInfoDal2") as IUserInfoDal;
            adoDal.Show();
            Console.ReadKey();
        }
    }
}
