using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NoContenXForms
{
    public partial class MainPage : ContentPage
    {
        public string ImageUrl => "http://10.10.0.80:5000/Picture/GetContent";

        public string NoContentUrl => "http://10.10.0.80:5000/Picture/GetNoContent";

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
