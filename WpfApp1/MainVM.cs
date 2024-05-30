using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.ML;

namespace WpfApp1
{
    internal partial class MainVM : ObservableRecipient
    {
        public MainVM()
        {
            listedBooks =
            [
                new Book()
                {
                    Title = "Ember tragédiája",
                    Author = new Author()
                    {
                        FirstName = "Imre",
                        LastName = "Madách"
                    }
                },
            ];
        }
        [ObservableProperty] private ObservableCollection<Book> listedBooks;
    }
}
