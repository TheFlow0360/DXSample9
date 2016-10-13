using System.Windows;
using System.Windows.Input;

namespace DXSample9
{
    public class DockChildViewModel
    {
        public DockChildViewModel()
        {
            NewCommand = new CommandBinding(ApplicationCommands.New, NewExecute, NewCanExecute);
            OpenCommand = new CommandBinding(ApplicationCommands.Open, OpenExecute);
        }

        private void OpenExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open dialog");
        }

        private void NewCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = AllowNew;
        }

        private void NewExecute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New dialog");
        }

        public CommandBinding NewCommand { get; private set; }

        public bool AllowNew { get; set; }

        public CommandBinding OpenCommand { get; private set; }
    }
}