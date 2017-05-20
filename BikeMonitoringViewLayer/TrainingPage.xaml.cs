using BusinessLayer;
using EntitiesLayer;
using System;
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
using System.Windows.Shapes;

namespace BikeMonitoringViewLayer
{
	/// <summary>
	/// Interaction logic for TrainingAddPage.xaml
	/// </summary>
	public partial class TrainingPage : Window
	{
		/// <summary>
		/// Default constructor of training page
		/// </summary>
		public TrainingPage()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Constructor of training add page for modification
		/// </summary>
		/// <param name="trainning">The training to modify</param>
		public TrainingPage(Training trainning)
		:this()
		{
			this.Title = "Bike monitoring - modify training";
			this.DataContext = trainning;
		}

		/// <summary>
		/// Whe the window is closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Owner.IsEnabled = true;
			this.Owner.Visibility = System.Windows.Visibility.Visible;
			this.Owner.Show();
			(this.Owner as TrainingsPage).Refresh();
		}

		/// <summary>
		/// Save the trainning added or modified on this page
		/// </summary>
		private void Save()
		{
			BusinessManager.SaveTraining((Training)DataContext);
		}


		/// <summary>
		/// Cancel the modifications
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bpCancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Validate the modifications
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bpValidate_Click(object sender, RoutedEventArgs e)
		{
			Save();
			this.Close();
		}


	}
}
