using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ML
{
    internal partial class Author : ObservableObject
    {
        public Author()
        {
            PropertyChanged += Author_PropertyChanged;
        }

        private void Author_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(FirstName):
                case nameof(LastName):
                    FullName = $"{FirstName} {LastName}";
                    break;
                default:
                    break;
            }
        }

        [ObservableProperty] private string? firstName;
        [ObservableProperty] private string? lastName;
        [ObservableProperty] private DateTime? birthDate;
        [ObservableProperty] private DateTime? deathDate;
        [ObservableProperty] private string? fullName;
    }
}
