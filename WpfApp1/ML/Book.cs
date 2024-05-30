using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ML
{
    internal partial class Book : ObservableObject
    {
        public Book()
        {
            genres = new ObservableCollection<Genre>();
        }
        [ObservableProperty] private string? title;
        [ObservableProperty] private DateTime? published;
        [ObservableProperty] private Author? author;
        [ObservableProperty] private ObservableCollection<Genre>? genres;
    }
}
