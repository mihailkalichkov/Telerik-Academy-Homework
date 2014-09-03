using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank.Common
{
    interface IWithDrawable
    {
        void WithDraw(decimal ammount);
    }
}