using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.ObjectModel;

namespace DXDialogDemo.Dialog
{
    public class DialogWindowViewModel 
    {
        public ObservableCollection<BaseHeaderItemModel> HeaderItems { get; private set; }
        public virtual bool ShowPredefinedItems { get; set; }

        public DialogWindowViewModel() { 
        InitializeHeaderItems();
        }
        void InitializeHeaderItems()
        {
            HeaderItems = new ObservableCollection<BaseHeaderItemModel>();
            var model = ViewModelSource<FirstDialogHeaderViewModel>.Create();
            model.SetParentViewModel(this);
            HeaderItems.Add(model);
            ShowPredefinedItems = true;
        }

    }
}
