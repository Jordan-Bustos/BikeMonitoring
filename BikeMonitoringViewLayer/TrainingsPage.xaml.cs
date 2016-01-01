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
	/// Interaction logic for Trainings.xaml
	/// </summary>
	public partial class TrainingsPage : Window
	{

		/// <summary>
		/// The training page
		/// </summary>
		private TrainingPage _trainingPage;

		/// <summary>
		/// Constructor of the trainings page
		/// </summary>
		public TrainingsPage()
		{
			InitializeComponent();
			LoadPage();
		}

		/// <summary>
		/// Load the page
		/// </summary>
		private void LoadPage()
		{
			lvTrainings.ItemsSource = BusinessManager.getTrainings();
			LoadSums();
		}

		/// <summary>
		/// Load the sum content
		/// </summary>
		private void LoadSums()
		{
			if (sPSums.Children.Count > 0)
			{
				sPSums.Children.Clear();
			}

			if (BusinessManager.getTrainings().Count()==0) return;

			sPSums.Children.Add(new Label { Content = "***** TOTAUX *****" });

			//Sums of distance traveled
			StringBuilder sb = new StringBuilder();
			sb.Append(BusinessManager.getTrainings().Sum(training => training.Distance).ToString()).Append(" km. parcourus");
			sPSums.Children.Add(new Label { Content = sb.ToString() });

			//Sums of heigth difference 
			sb = new StringBuilder();
			sb.Append(BusinessManager.getTrainings().Sum(training => training.HeightDifference).ToString()).Append(" m. de dénivelé franchis");
			sPSums.Children.Add(new Label { Content = sb.ToString() });

			//Sums of hours of trainings (min => hours)
			sb = new StringBuilder();
			sb.Append((BusinessManager.getTrainings().Sum(training => training.TrainingTimeMin) / 60).ToString()).Append(" h. passées sur le vélo");
			sPSums.Children.Add(new Label { Content = sb.ToString() });

			//Average of speed 
			sb = new StringBuilder();
			sb.Append(BusinessManager.getTrainings().Average(training => training.Average).ToString()).Append(" km/h. de moyenne");
			sPSums.Children.Add(new Label { Content = sb.ToString() });
			
		}

		/// <summary>
		/// When the window is closing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Owner.IsEnabled = true;
			this.Owner.Visibility = System.Windows.Visibility.Visible;
			this.Owner.Show();
		}

		/// <summary>
		/// When we click on contect menu "Ajouter un entrainement", go to the training page
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItem_Click_Add_Training(object sender, RoutedEventArgs e)
		{
			_trainingPage = new TrainingPage();
			_trainingPage.Owner = this;
			this.IsEnabled = false;
			this.Visibility = System.Windows.Visibility.Hidden;
			_trainingPage.Show();
		}
		
		/// <summary>
		/// When we click on context menu "Modifier"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItem_Click_Modify_Training(object sender, RoutedEventArgs e)
		{
			if (lvTrainings.SelectedItem != null)
			{
				Training training = (lvTrainings.SelectedItem) as Training;
				lvTrainings.SelectedItem = null;
				_trainingPage = new TrainingPage(training);
				_trainingPage.Owner = this;
				this.IsEnabled = false;
				this.Visibility = System.Windows.Visibility.Hidden;
				_trainingPage.Show();
			}
		}

		/// <summary>
		/// When we click on context menu "Supprimer"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItem_Click_Delete_Training(object sender, RoutedEventArgs e)
		{
			if (lvTrainings.SelectedItem != null)
			{
				Training training = (lvTrainings.SelectedItem) as Training;
				List<Training> trainings = new List<Training>();
				trainings.Add(training);
				BusinessManager.DeleteTraining(trainings);
				
				Refresh();
			}
		}

		/// <summary>
		/// Refresh the page
		/// </summary>
		public void Refresh()
		{
			LoadPage();
		}

		/// <summary>
		/// When we click on the menu item "Semaine"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MIWeek_Click(object sender, RoutedEventArgs e)
		{
			BusinessManager.Mode = 1;
			Refresh();
		}

		/// <summary>
		/// When we click on the menu item "Mois"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MIMonth_Click(object sender, RoutedEventArgs e)
		{
			BusinessManager.Mode = 2;
			Refresh();
		}

		/// <summary>
		/// When we click on the menu item "année"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MIYear_Click(object sender, RoutedEventArgs e)
		{
			BusinessManager.Mode = 3;
			Refresh();
		}

		/// <summary>
		/// When we click on the menu item "Années cumulées"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MIAll_Click(object sender, RoutedEventArgs e)
		{
			BusinessManager.Mode = 4;
			Refresh();
		}
	}
}
