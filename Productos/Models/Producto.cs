using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Productos.Models
{
    public class Producto
    {
        [Key]  // Especifica que es clave primaria
        public int CodigoProducto { get; set; }

        [StringLength(35)]  // Longitud máxima de 35 caracteres
        public string DescripcionProducto { get; set; }

        [Column(TypeName = "money")]  // Define el tipo money en la base de datos
        public decimal CostoProducto { get; set; }

        [Column(TypeName = "money")]
        public decimal PrecioProducto { get; set; }

        public int ExistenciaProducto { get; set; }

        [StringLength(1)]  // Longitud de 1 carácter
        public string EstatusProducto { get; set; }
    }
}
