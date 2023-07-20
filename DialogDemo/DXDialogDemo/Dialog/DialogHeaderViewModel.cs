using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System;

namespace DXDialogDemo.Dialog
{
    public abstract class BaseHeaderItemModel
    {
        public virtual bool IsVisible { get; set; }
        public DialogWindowViewModel BaseModel { get { return this.GetParentViewModel<DialogWindowViewModel>(); } }

        public string ResourceKey { get; set; }
    }

    public class FirstDialogHeaderViewModel :BaseHeaderItemModel
    {
        public FirstDialogHeaderViewModel() { ResourceKey = "FirstHeaderControlItem"; IsVisible = true; }

    }
}
