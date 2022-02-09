using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PokeApp.ViewModels;
using PokeApp.Models;

using Xamarin.Forms;

namespace PokeApp.Views
{
    public partial class Liste : ContentView
    {
        public Liste()
        {
            InitializeComponent();
            BindingContext = new PokemonsVM();
        }
    }
}