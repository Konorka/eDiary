using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KoNorBeadando
{
    public class BaseModel
    {
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChange([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public class BindingCommand : ICommand
        {
            readonly Action<object> _execute;

            public BindingCommand(Action<object> execute)
            {
                _execute = execute;
            }
            public BindingCommand(Action execute)
            {
                _execute = parameter => execute();
            }

            public event EventHandler CanExecuteChanged;
            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _execute(parameter);
            }
        }
    }