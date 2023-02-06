using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCommand
{
    public interface IModelCommand
    {
        public string NameCommand { get; } // полное название команды
        public string SkinCommnad { get; } // сокращенное название команды
        public string Callback(); // возвращаемый ответ
    }
}
