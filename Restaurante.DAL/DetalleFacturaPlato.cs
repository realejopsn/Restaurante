//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurante.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFacturaPlato
    {
        public int IdDetalleFacturaPlato { get; set; }
        public int IdFactura { get; set; }
        public int IdPlato { get; set; }
        public int Cantidad { get; set; }
        public string Notas { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Plato Plato { get; set; }
    }
}