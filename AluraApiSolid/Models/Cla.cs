using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AluraApiSolid.Models
{
    public class Cla
    {
        public Cla()
        {
            Ninjas = new Collection<Ninja>();
        }
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Ninja> Ninjas { get; set; }
    }
}
