//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EleganciaWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class DireccionCliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DireccionCliente()
        {
            this.Clientes = new HashSet<Cliente>();
        }
    
        public int IdDireccion { get; set; }
        public int IdMunicipio { get; set; }
        public string Direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual MunicipioCliente MunicipioCliente { get; set; }
    }
}
