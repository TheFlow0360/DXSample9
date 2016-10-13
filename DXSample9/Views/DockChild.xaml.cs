namespace DXSample9.Views
{
    /// <summary>
    /// Interaction logic for DockChild.xaml
    /// </summary>
    public partial class DockChild
    {
        private DockChildViewModel viewModel;

        public DockChild()
        {
            InitializeComponent();
            viewModel = new DockChildViewModel();
            DataContext = viewModel;

            CommandBindings.Add(viewModel.NewCommand);
            CommandBindings.Add(viewModel.OpenCommand);
        }
    }
}
