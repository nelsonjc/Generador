using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Generador.Entity.dto
{
	public class Categoriadto
	{
	 [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categoriadto()
        {
            ProductoCategoria = new HashSet<ProductoCategoria>();
        }

        public int Id { get; set; }

		[Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public bool Estado { get; set; }

	}
}