using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNetDemo
{
    public class CheckableItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsChecked)));
                    foreach (CheckableItem child in Children)
                    {
                        child.IsChecked = value;
                    }
                }
            }
        }

        public ObservableCollection<CheckableItem> Children { get; set; }=new ObservableCollection<CheckableItem> { 
            new CheckableItem { 
            IsChecked = true,
            Value="110"
            },
            new CheckableItem {
            IsChecked = true,
            Value="120"
            },
        };

        public string Value { get; set; }
    }
}
