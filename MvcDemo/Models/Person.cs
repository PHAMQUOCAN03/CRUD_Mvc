using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo.Models
{
    public class Person
    {
        [Key]
       public int PersonId { get; set; }
       public string  Fullname { get; set; }

       public string Address { get; set; }

       
    }
}