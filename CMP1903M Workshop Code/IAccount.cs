﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    interface IAccount : IAccountReport
    {
        //Interface to allow getting the balance, depositing and withdrawing
        bool Deposit(decimal value);
        bool Withdraw(decimal value);
    }
}
