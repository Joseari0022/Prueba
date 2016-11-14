using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Obras
    {
        [Key]
        public int ObraId { get; set; }
        public string Nombres { get; set; }

        public virtual List<Ingeniero> Ingeniero { get; set; }
        public Obras()
        {
            this.Ingeniero = new List<Ingeniero>();
        }

        public Obras(int idobras, string nombres)
        {
            this.ObraId = idobras;
            this.Nombres = nombres;
            this.Ingeniero = new List<Ingeniero>();
        }
             
    } 
}
