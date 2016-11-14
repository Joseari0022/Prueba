using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingeniero
    {
        [Key]
        public int IngenieroId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Obras> Obras { get; set; }
        public Ingeniero()
        {
            this.Obras = new List<Obras>();
        }

        public Ingeniero(int IdIngeniero, string nombres)
        {
            this.IngenieroId = IdIngeniero;
            this.Nombres = nombres;
            this.Obras = new List<Obras>();
        }
    }
}
