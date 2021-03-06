﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gibdd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        private readonly Action<string> onResult;
        public TabbedPage1(string title, Action<string> onResult)
        {
            InitializeComponent();
            Title = title;
            this.onResult = onResult;
            this.onResult?.Invoke("I'm tabbed");
        }
    }
}