using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	/// <summary>
	/// The data access layer manager (DAL Manager) allow to access data of the application
	/// </summary>
    public class DalManager
    {
		/// <summary>
		/// Return the list of trainings save in file choose
		/// </summary>
		/// <returns>The list of training</returns>
		public static List<Training> getTrainings()
		{
			List<Training> trainings = new List<Training>();

			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 10), 13, 23, 123, 90, 100, 45, "Nuageux"));
			trainings.Add(new Training(new DateTime(2015, 12, 11), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 11, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 14), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 31), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 05, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 05, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 10), 13, 23, 123, 90, 100, 45, "Nuageux"));
			trainings.Add(new Training(new DateTime(2015, 12, 11), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015, 12, 12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015,12,12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015,12,12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015,12,12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015,12,12), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));
			trainings.Add(new Training(new DateTime(2015,12,11), 12, 23, 120, 90, 100, 45, "Ce n'était pas facile"));

			return trainings;
		}
    }
}
