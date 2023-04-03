using System;
namespace DataBaseFirst.Data.Models
{
	public class Book_Author
	{
		public string BookId { get; set; }
		public string AuthorId { get; set; }


		public Book Book { get; set; }
		public Author Author { get; set; }

		public Book_Author()
		{
		}
	}
}

