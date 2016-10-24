using System;
using DevExpress.Xpf.Docking.Base;
using DevExpress.Xpf.Ribbon;

namespace DXSample9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DockLayoutManager_OnDockOperationCompleted(object sender, DockOperationCompletedEventArgs e)
        {
            if (e.DockOperation == DevExpress.Xpf.Docking.DockOperation.Dock)
                Dispatcher.BeginInvoke((Action)(() => { e.Item.IsActive = true; }));
        }
    }
}
