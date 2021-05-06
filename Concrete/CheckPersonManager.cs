using InterfaceAbstractHomeWork.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractHomeWork.Concrete
{
    internal class CheckPersonManager : IPersonCheck
    {
        public bool CheckId(Gammer gammer)
        {
            return true;
        }
    }
}