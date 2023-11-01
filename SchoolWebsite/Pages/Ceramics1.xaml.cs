using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace SchoolWebsite.Pages
{
	public partial class Ceramics1 : Page
	{
		public Ceramics1()
		{
			this.InitializeComponent();
		}

		private void Button_MouseEnter(object sender, MouseEventArgs e)
		{
			((Button)sender).MinHeight = 1;
        }

		private void Button_MouseLeave(object sender, MouseEventArgs e)
		{
			((Button)sender).MinHeight = 0;
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Source = new Uri("/Pages/Projects/PinchPotMonster.xaml", UriKind.Relative);
			MainPage.Presenter.Visibility = Visibility.Visible;
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Source = new Uri("/Pages/Projects/CoilPot.xaml", UriKind.Relative);
			MainPage.Presenter.Visibility = Visibility.Visible;
		}

		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Source = new Uri("/Pages/Projects/SlabProject.xaml", UriKind.Relative);
			MainPage.Presenter.Visibility = Visibility.Visible;
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Source = new Uri("/Pages/Projects/TripodMug.xaml", UriKind.Relative);
			MainPage.Presenter.Visibility = Visibility.Visible;
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Source = new Uri("/Pages/Projects/WheelThrownPots.xaml", UriKind.Relative);
			MainPage.Presenter.Visibility = Visibility.Visible;
		}

		private void Button_Click_5(object sender, RoutedEventArgs e)
		{
			MainPage.Presenter.Source = new Uri("/Pages/Projects/KoreanWaterDropper.xaml", UriKind.Relative);
			MainPage.Presenter.Visibility = Visibility.Visible;
		}
	}
}
