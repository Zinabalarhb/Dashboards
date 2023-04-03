using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseFirst.Data.Models
{
	[Table(name:"alnasher")]
	public class Publisher
	{
		public string Id { get; set; }
		public String Name { get; set; }

		public IEnumerable<Book> Books { get; set; }

		public Publisher()
		{
			Id = Guid.NewGuid().ToString();
		}
	}
}

