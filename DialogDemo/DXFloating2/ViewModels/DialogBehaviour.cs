using DevExpress.Mvvm;
using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Docking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DXFloating2.ViewModels
{
    public class DialogBehaviour : Behavior<DevExpress.Xpf.Docking.VisualElements.ControlBoxButton>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Loaded += AssociatedObject_Loaded;
        }

        private void AssociatedObject_Loaded(object sender, RoutedEventArgs e)
        {
            this.AssociatedObject.Command = new DelegateCommand(() => CloseDialog());
        }

        private void CloseDialog()
        {
            var group = DockLayoutManager.GetLayoutItem(this.AssociatedObject) as FloatGroup;
            if (group != null)
                foreach (var item in group.Items.ToList())
                    group.GetDockLayoutManager().DockController.Close(item);
        }
        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= AssociatedObject_Loaded;
            base.OnDetaching();
        }
    }

}
