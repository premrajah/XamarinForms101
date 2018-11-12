using System;
using System.Collections.Generic;
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
		public ListPage ()
		{
			InitializeComponent ();

            myList.ItemsSource = new List<Models.Contact>
            {
                   new Models.Contact(){Name = "Prem Rajah", Status = "Let's talk", ImageUrl ="https://placeimg.com/100/100/people"},
                   new Models.Contact(){Name = "Mike Jackson", Status = "Time to party", ImageUrl ="https://placeimg.com/100/100/people"},
                   new Models.Contact(){Name = "Patrick Paul", Status = "Zoom Zoom Zoom", ImageUrl ="https://placeimg.com/100/100/people"}
            };
		}
	}
}