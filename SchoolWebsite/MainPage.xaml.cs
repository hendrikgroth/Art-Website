using SchoolWebsite.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SchoolWebsite
{
	public partial class MainPage : Page
	{
		public static Frame Presenter { get; set; }

		public MainPage()
		{
			this.InitializeComponent();

			Presenter = projectpresenter;
		}

		private void RadioButton_Checked(object sender, RoutedEventArgs e)
		{
			NavigateToPage("/HomePage");
		}

		private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
		{
			NavigateToPage("/Ceramics1");
		}

		private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
		{
			NavigateToPage("/Drawing1");
		}

		private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
		{
			NavigateToPage("/About");
		}

		void NavigateToPage(string targetUri)
		{
			// Navigate to the target page:
			Uri uri = new Uri(targetUri, UriKind.Relative);
			PageContainer.Source = uri;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Visibility = Visibility.Collapsed;
		}
	}
}
