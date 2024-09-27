// namespace MvcCRUD.Models
// {
//     public class Person
//     {
//         public string PersonId {get; set;}

//         public string FullName {get; set;}

//         public string Adress {get; set;}
//     }

// }
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCRUD.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; } 
    
        public Person(string personId, string fullName, string address)
        {
            PersonId = personId;
            FullName = fullName;
            Address = address; 
        }
    }
}
