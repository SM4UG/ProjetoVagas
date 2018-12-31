﻿using ProjetoVagas.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjetoVagas.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class JobDetail : ContentPage
	{
		public JobDetail (Vagas job)
		{
			InitializeComponent ();
            DisplayAlert("Vaga", job.JobTitle,"OK");
		}

        public void CloseModal(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();

        }
    }
}