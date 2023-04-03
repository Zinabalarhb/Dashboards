using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseFirst.Data.Models
{
    public class PhoneNumber
    {
        
        public string AuthorId { get; set; }
        public string MobileNumber { get; set; }




        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
    }
}