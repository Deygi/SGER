//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SGER.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Sample = new HashSet<Sample>();
            this.Ubigeo = new HashSet<Ubigeo>();
        }
    
        public int idProducto { get; set; }
        public string nomProduct { get; set; }
        public Nullable<int> idTypeProduct { get; set; }
        public Nullable<int> idTypeUnit { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual typeProduct typeProduct { get; set; }
        public virtual typeUnit typeUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sample> Sample { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ubigeo> Ubigeo { get; set; }
    }
}
