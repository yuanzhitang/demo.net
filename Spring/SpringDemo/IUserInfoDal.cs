﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringDemo
{
    public interface IUserInfoDal
    {
        UserInfo UserInfo { get; set; }
        string Name { get; set; }
        void Show();
    }
}
