using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AluraApiSolid.Models
{
    public class Ninja
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Idade { get; set; }
        public virtual Cla Cla { get; set; }
        [ForeignKey("ClaId")]
        public int ClaId { get; set; }
        public virtual Vila Vila { get; set; }
        [ForeignKey("VilaId")]
        public int VilaId { get; set; }

    }
}
