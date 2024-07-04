namespace WebApplication1.Models
{
	public record MyUser(string Name, int Age);


	/*    public class MyUser
		{

			public int Id { get; set; }
			public string? Name { get; set; } // имя пользователя
			public int Age { get; set; } // возраст пользователя

			public MyUser (string name, int age)
			{
				Name = name; 
				Age = age; 
			}


		}*/
	public class MyGroup
	{
		public static List<MyUser> All { get; set; } = new List<MyUser>();
	}
}
