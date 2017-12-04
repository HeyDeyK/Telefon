using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public Kontakt kontakt = new Kontakt();
        public Seznam()
        {
            InitializeComponent();
            
            ObservableCollection<NewItem> kontakty = new ObservableCollection<NewItem>();
            kontakty.Add(new NewItem { Text = "Adam", Image = "logic.png" });
            kontakty.Add(new NewItem { Text = "Bertík", Image = "logic.png" });
            kontakty.Add(new NewItem { Text = "Jenda", Image = "logic.png" });
            kontakty.Add(new NewItem { Text = "Ondra", Image = "logic.png" });
            kontakty.Add(new NewItem { Text = "Smrk", Image = "logic.png" });
            kontakty.Add(new NewItem { Text = "Ročejdl", Image = "logic.png" });

            list.ItemsSource = kontakty;

        }
        private void KontaktTap(object sender, ItemTappedEventArgs e)
        {
            kontakt.BindingContext = list.SelectedItem;
            Navigation.PushModalAsync(kontakt);
        }
    }
}