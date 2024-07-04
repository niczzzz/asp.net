using Movies_razor.Models;
using System.Text;

namespace Movies_razor.Models
{
	public class PictureShow
	{
		public DateTime Day { get; set; }
		public int Price { get; set; }
		public TimeSpan Time { get; set; }
		public int MovieId { get; set; }
		public PictureShow(string day, int price, TimeSpan time, int id)
		{
			Day = DateTime.Parse(day);
			Price = price;
			Time = time;
			MovieId = id;
		}
	}

	public class Schedule
	{
		public static List<PictureShow> schedules { get; set; } = new List<PictureShow>();
	}	
}