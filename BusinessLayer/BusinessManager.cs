using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
	/// <summary>
	/// Business logic of the application here
	/// </summary>
    public class BusinessManager
    {
		
		/// <summary>
		/// List of the trainings
		/// </summary>
		private static IEnumerable<Training> _trainings;

		/// <summary>
		/// List of the trainings
		/// </summary>
		private static IEnumerable<Training> Trainings
		{
			get { return _trainings; }
			set { _trainings = value; }
		}

		/// <summary>
		/// Mode of application
		///		1 : week
		///		2 : month
		///		3 : year
		///		4 : all
		/// </summary>
		private static int _mode = 2;

		/// <summary>
		/// Mode of application
		///		1 : week
		///		2 : month
		///		3 : year
		///		4 : all
		/// </summary>
		public static int Mode
		{
			get { return _mode; }
			set { _mode = value; }
		}


		/// <summary>
		/// Return the list of training wanted
		/// </summary>
		/// <returns>The list of training wanted</returns>
		public static IEnumerable<Training> getTrainings()
		{
			// Local list of trainings
			IEnumerable<Training> trainings = Trainings;

			// If list of trainings is null
			if (trainings == null)
			{
				// then we read the file to fill in it
				trainings = DalManager.getTrainings();
				Trainings = trainings;	 
			}				

			// We create a date tile format info (dfi) and a calendar (cal) for compare week of date later (in th switch case)
			DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
			Calendar cal = dfi.Calendar;
			
			switch (Mode)
			{
				// **** week ****
				case 1: 
					trainings = from training
								in trainings
								orderby training.Day ascending
								where	(
											(training.Day.Year == DateTime.Now.Year)
											&&
											(training.Day.Month == DateTime.Now.Month)
											&&
											(cal.GetWeekOfYear(training.Day, dfi.CalendarWeekRule, dfi.FirstDayOfWeek) == cal.GetWeekOfYear(DateTime.Now, dfi.CalendarWeekRule, dfi.FirstDayOfWeek))
										)
								select training;
					break;

				// **** month ****
				case 2:
					trainings = from training
								in trainings
								orderby training.Day ascending
								where (
											(training.Day.Year == DateTime.Now.Year)
											&&
											(training.Day.Month == DateTime.Now.Month)
										)
								select training;
					break;

				// **** year ****
				case 3:
					trainings = from training
								in trainings
								orderby training.Day ascending
								where (
											(training.Day.Year == DateTime.Now.Year)
										)
								select training;
					break;

				// **** all ****
				case 4:
					trainings = from training
								in trainings
								orderby training.Day ascending
								select training;
					break;
					
							
				default:
					break;
			}

			return trainings;
		}

		/// <summary>
		/// Remove trainings
		/// </summary>
		/// <param name="training">Trainings to remove</param>
		public static void DeleteTraining(List<Training> trainings)
		{
			Trainings = Trainings.Except(trainings);
		}
	}
}
