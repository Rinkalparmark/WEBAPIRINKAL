using System.ComponentModel.DataAnnotations;

namespace WebAPI.Model
{
    public partial class Emp
    {
        [Key]
        public int Employee_Id { get; set; }

        public string Employee_Name { get; set;}
    }
}
