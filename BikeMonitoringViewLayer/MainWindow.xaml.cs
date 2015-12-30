using BusinessLayer;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BikeMonitoringViewLayer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		/// <summary>
		/// The training page
		/// </summary>
		private TrainingsPage _trainingPage;

		/// <summary>
		/// Main window constructor
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		/// When we click on the button to go to the training page
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void bpGoToTrainingsPage_Click(object sender, RoutedEventArgs e)
		{
			_trainingPage = new TrainingsPage();
			_trainingPage.Owner = this;
			this.IsEnabled = false;
			this.Visibility = System.Windows.Visibility.Hidden;
			_trainingPage.Show();
		}
	}
}
