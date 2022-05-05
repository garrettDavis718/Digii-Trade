﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PlansLib;

namespace WpfUI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class PlansWindow : Window
	{
		public PlansWindow(User user)
		{
				
			InitializeComponent();
			UserLbl.Content = user.FirstName + " " + user.LastName;
		}

        private void CreatePlansBtn_Click(object sender, RoutedEventArgs e)
        {
			SchedulerWindow scheduler = new SchedulerWindow();
			scheduler.Show();

		}

        private void SearchPlansBtn_Click(object sender, RoutedEventArgs e)
        {
			
			if (MessageBox.Show("Do you want to search Plans by Maps?", "Plans", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
			{
				//do no stuff
				SchedulerWindow scheduler = new SchedulerWindow();
				scheduler.Show();
			}
			else
			{
				//do yes stuff
				MapsWindow mapsWindow = new MapsWindow();
				mapsWindow.Show();
			}			
		}
    }
}