using System;

namespace PureCinema.DataAccess.Models
{
	public class MovieTime
	{
		public int MovieId { get; set; }
		public TimeSpan StartTime { get; set; }
		public TimeSpan EndTime { get; set; }
	}
}
