using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrialApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
        private ObservableCollection<Models.Contact> _contact;

		public ListPage ()
		{
			InitializeComponent ();

            _contact = new ObservableCollection<Models.Contact>
                {
                    new Models.Contact(){Name = "Prem Rajah", Status = "Let's talk", ImageUrl ="https://placeimg.com/100/100/people"},
                     new Models.Contact(){Name = "Mike Jackson", Status = "Time to party", ImageUrl ="https://placeimg.com/100/100/people"},
                     new Models.Contact(){Name = "Clark Kent", Status = "Zoom Zoom Zoom", ImageUrl ="https://placeimg.com/100/100/people"}

                };

            myList.ItemsSource = _contact;
		}

      


        private void call_clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Models.Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void delete_clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Models.Contact;
            _contact.Remove(contact);

        }
    }
}