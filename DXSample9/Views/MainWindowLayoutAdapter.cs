using DevExpress.Xpf.Docking;

namespace DXSample9.Views
{
    public class MainWindowLayoutAdapter : ILayoutAdapter
    {
        public string Resolve(DockLayoutManager owner, object item)
        {
            var layoutPanel = item as BaseLayoutItem;
            if (layoutPanel == null)
            {
                return "DocumentHost";
            }

            owner.LayoutController.Activate(layoutPanel);
            return layoutPanel.Tag as string;
        }
    }
}