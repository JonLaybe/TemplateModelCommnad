using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerCommand
{
    public class AuthCommand : IModelCommand // команда
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        private string _str_command;
        public string NameCommand { get; }
        public string SkinCommnad { get; }

        public AuthCommand(string name_command, string skin_command, string command)
        {
            NameCommand = name_command;
            SkinCommnad = skin_command;
            _str_command = command;
        }

        public ModelCommand Command
        {
            get
            {
                return new ModelCommand(() =>
                {
                    string[] array = _str_command.Split(' ');

                    Login = array[1];
                    Password = array[2];
                }, () =>
                {
                    string[] array = _str_command.Split(' ');
                    return array.Length == 3 && array[0] == $"<{SkinCommnad}>";
                });
            }
        }

        public string Callback()
        {
            if (Command.CheckCommand())
            {
                return "{'Auth': 'True' }";
            }
            return "{'Auth': 'False' }";
        }
    }
}
