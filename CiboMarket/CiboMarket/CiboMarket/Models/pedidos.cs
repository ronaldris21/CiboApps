//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CiboMarket.Models
{
    using SQLite;
    using System;
    using System.Collections.Generic;
    
    public partial class pedidos
    {
        [PrimaryKey,AutoIncrement]
        public int idPedido { get; set; }
        public Nullable<int> idUser { get; set; }
        public Nullable<int> idRepartidor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<System.TimeSpan> hora { get; set; }
        public Nullable<float> total { get; set; }
        public Nullable<float> xlat { get; set; }
        public Nullable<float> ylat { get; set; }
        public string comentarios { get; set; }
        public string estado { get; set; }
        public Nullable<float> puntajeServicio { get; set; }
        public string metodoPago { get; set; }
    }
}
