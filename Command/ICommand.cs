using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCommand
{
    public interface ICommand
    {
        bool CheckCommand(); // проверка команды
        void Handler(); // реализация команды
    }
}
