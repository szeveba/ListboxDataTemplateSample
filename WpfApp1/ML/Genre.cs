﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ML
{
    internal partial class Genre : ObservableObject
    {
        [ObservableProperty] private string? name;
        [ObservableProperty] private string? description;
    }
}
