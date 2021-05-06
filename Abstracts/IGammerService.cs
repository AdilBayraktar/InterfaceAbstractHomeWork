using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractHomeWork.Abstracts
{
    internal interface IGammerService
    {
        void Add(Gammer gammer);

        void Update(Gammer gammer);

        void Delete(Gammer gammer);
    }
}