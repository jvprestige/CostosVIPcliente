//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fechas
    {
        public Fechas()
        {
            this.Ordenes = new HashSet<Ordenes>();
            this.Pedidos = new HashSet<Pedidos>();
            this.Pedidos1 = new HashSet<Pedidos>();
            this.Salidas = new HashSet<Salidas>();
            this.CostosPptoProg = new HashSet<CostosPptoProg>();
            this.CostoEntrado = new HashSet<CostoEntrado>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Proyecto { get; set; }
        public string Tipo { get; set; }
    
        public virtual Proyectos Proyectos { get; set; }
        public virtual ICollection<Ordenes> Ordenes { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Pedidos> Pedidos1 { get; set; }
        public virtual ICollection<Salidas> Salidas { get; set; }
        public virtual ICollection<CostosPptoProg> CostosPptoProg { get; set; }
        public virtual ICollection<CostoEntrado> CostoEntrado { get; set; }
    }
}