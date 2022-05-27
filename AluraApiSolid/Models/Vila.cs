using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AluraApiSolid.Models
{
    public class Vila
    {
        public Vila()
        {
            Ninjas = new Collection<Ninja>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Ninja> Ninjas { get; set; }
    }
}
