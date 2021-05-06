using InterfaceAbstractHomeWork.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractHomeWork
{
    public class GammerManager : IGammerService
    {
        void IGammerService.Add(Gammer gammer)
        {
            Console.WriteLine("Gammer is Added to database: " + gammer.FirstName);
        }

        void IGammerService.Update(Gammer gammer)
        {
            Console.WriteLine("Gammer is updated : " + gammer.FirstName);
        }

        void IGammerService.Delete(Gammer gammer)
        {
            Console.WriteLine("Gammer is deleted from database: " + gammer.FirstName);
        }
    }
}