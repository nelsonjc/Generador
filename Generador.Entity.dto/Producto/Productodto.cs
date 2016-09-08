using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Generador.Entity.dto
{
    public class Productodto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            ProductoCategoria = new HashSet<ProductoCategoria>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoCategoria> ProductoCategoria { get; set; }
    }
}