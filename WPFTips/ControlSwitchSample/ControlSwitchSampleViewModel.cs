using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTips.ControlSwitchSample {
    class ControlSwitchSampleViewModel : BindableBase{

        private List<String> strings = new List<string>(new String[] { "el1", "el2", "el3" });
        public List<String> Strings {
            get => strings;
            set {
                strings = value;
            }
        }

        private DelegateCommand switchCommand;
        public DelegateCommand SwitchCommand {
            get => switchCommand ?? (switchCommand = new DelegateCommand(
                () => DisplayFlag = !DisplayFlag
            ));
        }

        private bool displayFlag = false;
        public bool DisplayFlag {
            get => displayFlag;
            set => SetProperty(ref displayFlag, value);
        }

    }
}
