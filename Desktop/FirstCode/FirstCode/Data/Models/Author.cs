using System;
namespace DataBaseFirst.Data.Models
{
	public class Author
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }



		public  List<PhoneNumber> PhoneNumber { get; set; }
		public List<Book_Author> Book_Author { get; set; }
		public Author()
		{
            Id = Guid.NewGuid().ToString();
        }
	}
}

