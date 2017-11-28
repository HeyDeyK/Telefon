using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Telefon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Seznam : ContentPage
    {
        public Seznam()
        {
            InitializeComponent();
            NewItem item1 = new NewItem();
            item1.Text = "HALO";
            item1.ImageSource = "logic.png";
        }
    }
}