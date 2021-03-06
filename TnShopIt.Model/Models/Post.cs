﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using TnShopIt.Model.Abstract;

namespace TnShopIt.Model.Models
{
    [Table("Posts")]
    public class Post : Auitable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public int CategoryID { set; get; }
        public XElement MoreImages { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
    }
}