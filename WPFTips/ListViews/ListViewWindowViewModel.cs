using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WPFTips.ListViews {
    class ListViewWindowViewModel : BindableBase{


        private List<String> stringList = new List<String>(new string[] { "element1", "element2", "element3", "eelement4" });

        public List<String> StringList {
            get => stringList;
            private set {
                SetProperty(ref stringList, value);
            }
        
        }

        private DelegateCommand<ListViewItem> doubleClickCommand;
        
        public DelegateCommand<ListViewItem> DoubleClickCommand {
            get => doubleClickCommand ?? (doubleClickCommand = new DelegateCommand<ListViewItem>(
                (ListViewItem listViewItem) => System.Diagnostics.Debug.WriteLine(listViewItem)
            ));
        }

    }
}
