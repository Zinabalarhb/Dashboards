using System;
using System.ComponentModel.DataAnnotations.Schema;
using DataBaseFirst.Data.Models;

namespace DataBaseFirst.Data.Models
{
	public class Book
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

       //[ForeignKey("Publisher")]
        public string PublisherId { get; set; }




        public List<Book_Author> Book_Author { get; set; }
        public Publisher publisher { get; set; } //navag

		public Book()
		{
			Id = Guid.NewGuid().ToString();
		}
        public override string ToString()
        {
            return $"id={Id}\n" +
                $"name= {Name}\n" +
                $"publisher Name={publisher.Name}\n";
        }
    }

    

}

