using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        public Employee(string name, int age, string photo)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.age = age;
            this.photo = photo;
        }

        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string? photo { get; set; }

  
    }
}
