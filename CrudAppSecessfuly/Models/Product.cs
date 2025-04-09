using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudAppSecessfuly.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "กรุณาระบุชื่อ")]
        public string Name { get; set; }


        //[Range(ErrorMessage ="0000")]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "กรุณาระบุราคา")]
        public decimal Price { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Description { get; set; }
       
       

    }
}
