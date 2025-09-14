using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    // You'll likely see something like this if you use data annotations
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }
    }
}