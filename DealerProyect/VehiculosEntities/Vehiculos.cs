using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VehiculosEntities
{
     public class Vehiculos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public int Price { get; set; }

        [Required]
        public string Image { get; set; }

        [StringLength(300, ErrorMessage = "500 Characters Only!")]
        public string Description { get; set; }

        [Required]
        public string Category { get; set; }
       

    }
}
