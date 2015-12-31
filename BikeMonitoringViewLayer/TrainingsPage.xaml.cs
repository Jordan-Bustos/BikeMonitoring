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
		}

		/// <summary>
		/// When we click on contect menu "Ajouter un entrainement"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItem_Click_Add_Training(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Ajout d'entrainement");
		}

		/// <summary>
		/// When we click on context menu "Modifier"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MenuItem_Click_Modify_Training(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Modification entrainement");
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
		private void Refresh()
		{
			LoadPage();
		}
	}
}
