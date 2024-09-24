using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.Core
{
    internal class ObservableObject : InotifyPropertyChnaged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
