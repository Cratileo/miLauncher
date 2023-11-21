using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.UI.Xaml.Input;
using static ABI.System.Windows.Input.ICommand_Delegates;

namespace miLauncher.Command;

internal class AutoExit : ICommand
{
    private readonly Action<object> _execAction;
    private readonly Func<object, bool> _func;

    public AutoExit(Action<object> execAction, Func<object, bool> func)
    {
        _execAction = execAction;
        _func = func;
    }

    public event EventHandler CanExecuteChanged;
    public bool CanExecute(object parameter)
    {
        return _func(parameter);
    }

    public void Execute(object parameter)
    {
        _execAction(parameter);
    }
}
