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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace SchoolWebsite.Pages.Projects
{
	public partial class SlabProject : UserControl
	{
		public SlabProject()
		{
			this.InitializeComponent();
			img1.Source = images[0];
		}

		int pos = 0;

		BitmapImage[] images =
		{
			new BitmapImage(new Uri("/Assets/Images/IMG_0563.png", UriKind.Relative)),
			new BitmapImage(new Uri("/Assets/Images/IMG_0564.png", UriKind.Relative)),
			new BitmapImage(new Uri("/Assets/Images/IMG_0565.png", UriKind.Relative))
		};

		private void Border_MouseEnter(object sender, MouseEventArgs e)
		{
			b1.Visibility = Visibility.Visible;
			b2.Visibility = Visibility.Visible;
		}

		private void Border_MouseLeave(object sender, MouseEventArgs e)
		{
			b1.Visibility = Visibility.Collapsed;
			b2.Visibility = Visibility.Collapsed;
		}

		private void b1_Click(object sender, RoutedEventArgs e)
		{
			pos++;
			if (pos >= images.Length)
				pos = 0;
			if (pos < 0)
				pos = images.Length - 1;
			img1.Source = images[pos];
		}

		private void b2_Click(object sender, RoutedEventArgs e)
		{
			pos--;
			if (pos >= images.Length)
				pos = 0;
			if (pos < 0)
				pos = images.Length - 1;
			img1.Source = images[pos];
		}

		private void b1_MouseEnter(object sender, MouseEventArgs e)
		{
			((Button)sender).MinHeight = 0.8;
		}

		private void b1_MouseLeave(object sender, MouseEventArgs e)
		{
			((Button)sender).MinHeight = 0.6;
		}
	}
}
