using Caliburn.Micro;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Template
{
    [Export(typeof(ITabItem))]
    [ImplementPropertyChanged]
    public class DefaultTabViewModel : Screen, ITabItem 
    {
        public string Indirizzo { get; set; }

        public DefaultTabViewModel()
        {
            DisplayName = "Default Tab";

            Indirizzo = "This first Tab! Arghh!";
        }

    }
}
