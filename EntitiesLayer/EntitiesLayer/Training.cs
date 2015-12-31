using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    /// <summary>
    /// This class "Training" describe a training :
    ///     One training per day
    ///     Some values of performances
    /// </summary>
    public class Training
    {

		/// <summary>
		/// The training day
		/// </summary>
		private DateTime _day;

		/// <summary>
		/// The training day
		/// </summary>
		public DateTime Day
		{
			get { return _day; }
			set { _day = value; }
		}

		/// <summary>
		/// The training day in the list
		/// </summary>
		public String DayString
		{
			get 
			{ 
				StringBuilder sb = new StringBuilder();
				
				sb.Append(Day.Day).Append("/").Append(Day.Month).Append("/").Append(Day.Year);

				return sb.ToString();
			}
		}
		
		/// <summary>
		/// Distance traveled
		/// </summary>
		private float _distance;

		/// <summary>
		/// Distance traveled
		/// </summary>
		public float Distance
		{
			get { return _distance; }
			set { _distance = value; }
		}

		/// <summary>
		/// Height difference
		/// </summary>
		private float _heightDifference;

		/// <summary>
		/// Height difference
		/// </summary>
		public float HeightDifference
		{
			get { return _heightDifference; }
			set { _heightDifference = value; }
		}

		/// <summary>
		/// The training time in minute
		/// </summary>
		private float _trainingTimeMin;

		/// <summary>
		/// The training time in minute
		/// </summary>
		public float TrainingTimeMin
		{
			get { return _trainingTimeMin; }
			set { _trainingTimeMin = value; }
		}

		/// <summary>
		/// The average km/h
		/// </summary>
		public float Average
		{
			get { return (Distance * TrainingTimeMin) / 60; }
		}

		/// <summary>
		/// Average of cardiac frequency
		/// </summary>
		private float _cardiacFrequencyAverage;

		/// <summary>
		/// Average of cardiac frequency
		/// </summary>
		public float CardiacFrequencyAverage
		{
			get { return _cardiacFrequencyAverage; }
			set { _cardiacFrequencyAverage = value; }
		}

		/// <summary>
		/// Maximal cardiac frequency during the training
		/// </summary>
		private float _cardiacFrequencyMax;

		/// <summary>
		/// Maximal cardiac frequency during the training
		/// </summary>
		public float CardiacFrequencyMax
		{
			get { return _cardiacFrequencyMax; }
			set { _cardiacFrequencyMax = value; }
		}

		/// <summary>
		/// Pedal cadence
		/// </summary>
		private float _cadence;

		/// <summary>
		/// Pedal cadence
		/// </summary>
		public float Cadence
		{
			get { return _cadence; }
			set { _cadence = value; }
		}

		/// <summary>
		/// General comment of the training
		/// </summary>
		private String _genComment;

		/// <summary>
		/// General comment of the training
		/// </summary>
		public String GenComment
		{
			get { return _genComment; }
			set { _genComment = value; }
		}

		/// <summary>
		/// Constructor without parameters for the serealisation
		/// </summary>
		private Training()
		{}

		/// <summary>
		/// Constructor of a Training
		/// </summary>
		/// <param name="day">The training day</param>
		/// <param name="distance">Distance traveled</param>
		/// <param name="heightDifference">Height difference</param>
		/// <param name="trainingTime">Training time</param>
		/// <param name="cardiacFrequencyAverage">The average of cardiac frequency during training</param>
		/// <param name="cardiacFrequencyMax">The maximal cardiac frequency during training</param>
		/// <param name="cadence">Pedal cadence</param>
		/// <param name="genComment">General comment of the training</param>
		public Training (DateTime day, float distance, float heightDifference, float trainingTime, float cardiacFrequencyAverage, float cardiacFrequencyMax, float cadence, String genComment )
		{
			Day = day;
			Distance = distance;
			HeightDifference = heightDifference;
			TrainingTimeMin = trainingTime;
			CardiacFrequencyAverage = cardiacFrequencyAverage;
			CardiacFrequencyMax = cardiacFrequencyMax;
			Cadence = cadence;
			GenComment = genComment;
		}

		/// <summary>
		/// Override equals methode
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			Training other = null;
			try
			{
				other = obj as Training;
			}
			catch (Exception)
			{
				return false;
			}

			if (other != null)
				return other.Day.Equals(this.Day);
			else
				return false;
		}

		/// <summary>
		/// Override hashcode methode
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return this.Day.GetHashCode();
		}

    }
}
