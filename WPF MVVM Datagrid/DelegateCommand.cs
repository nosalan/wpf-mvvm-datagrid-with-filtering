using System;
using System.Windows.Input;

namespace ExpandableHeader
{
  public class DelegateCommand : ICommand
  {
    private readonly Action _execute;

    public event EventHandler CanExecuteChanged;

    public DelegateCommand(Action execute)
    {
      _execute = execute;
    }

    public bool CanExecute(object parameter)
    {
      return true;
    }

    public void Execute(object parameter)
    {
      _execute();
    }

    public void RaiseCanExecuteChanged()
    {
      if (CanExecuteChanged != null)
        CanExecuteChanged(this, EventArgs.Empty);
    }
  }
}
