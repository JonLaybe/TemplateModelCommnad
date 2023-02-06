using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCommand
{
    public class ModelCommand : ICommand
    {
        private Action _action;
        private Func<bool> _func;

        public ModelCommand(Action action, Func<bool> func)
        {
            _action = action;
            _func = func;
        }

        public bool CheckCommand() // проверка команды
        {
            return _func();
        }

        public void Handler() // реализация команды
        {
            if (CheckCommand())
                _action();
        }
    }
}
