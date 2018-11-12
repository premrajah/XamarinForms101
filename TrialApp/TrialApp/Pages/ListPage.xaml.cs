﻿using System;
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

            myList.ItemsSource = new List<Models.ContactGroup>
            {
                new Models.ContactGroup("P", "P")
                {
                    new Models.Contact(){Name = "Prem Rajah", Status = "Let's talk", ImageUrl ="https://placeimg.com/100/100/people"}
                },
                new Models.ContactGroup("M", "M")
                {
                    new Models.Contact(){Name = "Mike Jackson", Status = "Time to party", ImageUrl ="https://placeimg.com/100/100/people"}
                },
                new Models.ContactGroup("C", "C")
                {
                     new Models.Contact(){Name = "Clark Kent", Status = "Zoom Zoom Zoom", ImageUrl ="https://placeimg.com/100/100/people"}
                }
                  
            };
		}
	}
}