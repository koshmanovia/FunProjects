﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Rocky.Models
{
    public class Product
    {
        [Key]
        public int id{ get; set; }
        [Required]
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        [Range( 1, int.MaxValue )] 
        public int Price { get; set; }
        public string Image {  get; set; }
        [Display(Name="Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey( "CategoryId" )]
        public virtual Category Category { get; set; }

        [Display(Name = "Application Type")]
        public int ApplicationTypeId { get; set; }
        [ForeignKey("ApplicationTypeId")]
        public virtual ApplicationType ApplicationType { get; set; }
    }
}
