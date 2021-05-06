using InterfaceAbstractHomeWork.Abstracts;
using InterfaceAbstractHomeWork.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractHomeWork.Concrete
{
    internal class GamesManager : IGamesService
    {
        public void Buy(Gammer gammer, Games game)
        {
            Console.WriteLine($"{gammer.FirstName} - is buyed {game.GameName} game.. ");
        }
    }
}