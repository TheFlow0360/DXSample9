using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using DevExpress.Xpf.Docking;
using DevExpress.Xpf.Docking.Base;
using DevExpress.Xpf.Ribbon;
using DXSample9.Views;

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
            Views = new ObservableCollection<BaseLayoutItem>();
            DockLayoutManager.ItemsSource = Views;

            AddToDocumentHost(new DockChild());
        }

        private ObservableCollection<BaseLayoutItem> Views { get; }

        private void DockLayoutManager_OnDockOperationCompleted(object sender, DockOperationCompletedEventArgs e)
        {
            if (e.DockOperation == DevExpress.Xpf.Docking.DockOperation.Dock)
                Dispatcher.BeginInvoke((Action)(() => { e.Item.IsActive = true; }));
        }

        public void AddToDocumentHost(UserControl view)
        {
            var child = new DocumentPanel
            {
                Caption = "Test",
                Content = view,
                DataContext = view.DataContext,
                ClosingBehavior = ClosingBehavior.ImmediatelyRemove,
                Tag = "DocumentHost"
            };

            Views.Add(child);
        }
    }
}
