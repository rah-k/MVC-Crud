

using System.ComponentModel.DataAnnotations;

namespace CurdOperation.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Standard { get; set; }
        public int Age { get; set; }
    }
}
