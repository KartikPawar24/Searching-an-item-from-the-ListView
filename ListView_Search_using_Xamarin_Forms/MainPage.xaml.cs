using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView_Search_using_Xamarin_Forms
{
    public partial class MainPage : ContentPage
    {
        List<string> names = new List<string>
        {
            "Kartik","Dinesh","Deepak","Rahul","Amar","Samson"
        };
        public MainPage()
        {
            InitializeComponent();

            NamesListView.ItemsSource = names;
        }
       void Search_btnPressed(object sender,EventArgs e)
        {
            var keyword = MainSearchBar.Text;

            NamesListView.ItemsSource=
                names.Where(name =>name.ToLower().Contains(keyword.ToLower()));
        }
    }
}
