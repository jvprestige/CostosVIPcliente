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
    
    public partial class Ordenes
    {
        public int Id { get; set; }
        public string Referencia1 { get; set; }
        public string Presupuesto { get; set; }
        public string Cod_Unit { get; set; }
        public string Unitario { get; set; }
        public string Cod_Insumo { get; set; }
        public string Insumo { get; set; }
        public string Und { get; set; }
        public Nullable<decimal> Comp { get; set; }
        public Nullable<decimal> Ent { get; set; }
        public Nullable<decimal> PorEnt { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Orden { get; set; }
        public string Tipo { get; set; }
        public string Cod_Prov { get; set; }
        public string Proveedor { get; set; }
        public Nullable<decimal> VlrUnita { get; set; }
        public Nullable<decimal> CostEnt { get; set; }
        public string Usuario { get; set; }
        public Nullable<int> IdFecha { get; set; }
    
        public virtual Fechas Fechas { get; set; }
    }
}
