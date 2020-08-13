using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTips.ControlSwitchSample {
    class ControlSwitchSampleViewModel {

        private List<String> strings = new List<string>(new String[] { "el1", "el2", "el3" });

        public List<String> Strings {
            get => strings;
            set {
                strings = value;
            }
        }

    }
}
