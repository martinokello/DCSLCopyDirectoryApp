using CopyDirectoryEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CopyDirectoryEngine.Annotations;

namespace CopyDirectoryEngine.Concretes
{
    public class OperationProgress : IProgress, INotifyPropertyChanged
    {
        private int _progress;
        public OperationProgress()
        {
            Progress = 0;
        }
        public int Progress
        {
            get { return _progress; }
            set { _progress = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
