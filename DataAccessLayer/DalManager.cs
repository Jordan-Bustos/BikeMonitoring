using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
		public static List<Training> GetTrainings()
		{
			return Load();
		}

		/// <summary>
		/// Load the data file
		/// </summary>
		/// <returns>The list of Trainings saved</returns>
		private static List<Training> Load()
		{
			List<Training> trainings = new List<Training>();

			String path = "../../../BikeMonitoringData.xml";
			if (File.Exists(path))
			{
				XmlSerializer reader = new XmlSerializer(typeof(List<Training>));
				StreamReader file = new StreamReader(path);
				trainings = (List<Training>)reader.Deserialize(file);
				file.Close();
			}

			return trainings;
		}

		/// <summary>
		/// Save the data file
		/// </summary>
		public static void Save(IEnumerable<Training> trainings)
		{
			String path = "../../../BikeMonitoringData.xml";
			XmlSerializer writer = new XmlSerializer(typeof(List<Training>));
			StreamWriter file = new StreamWriter(path);
			writer.Serialize(file, trainings.ToList());
			file.Close();
		}
	}
}
