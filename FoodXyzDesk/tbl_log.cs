//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodXyzDesk
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_log
    {
        public int id_log { get; set; }
        public Nullable<System.DateTime> waktu { get; set; }
        public string aktivitas { get; set; }
        public Nullable<int> id_user { get; set; }
    
        public virtual tbl_user tbl_user { get; set; }
    }
}