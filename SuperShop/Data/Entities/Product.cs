using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SuperShop.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required] //Nome vai ser obrigatório preencher

        //O campo nome não pode conter mais do que 50 caracteres
        [MaxLength(50, ErrorMessage ="The field {0} can contain {1} characters length.")]
        public string Name { get; set; }


        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }


        [Display(Name = "Image")]
        public string ImageUrl { get; set; }


        [Display(Name = "Last Purchase")]
        public DateTime? LastPurchase { get; set; } // A data será opcional


        [Display(Name = "Last Sale")]
        public DateTime? LastSale { get; set; }


        [Display(Name = "Last Sale")]
        public bool IsAvailable { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }
       
    }
}

