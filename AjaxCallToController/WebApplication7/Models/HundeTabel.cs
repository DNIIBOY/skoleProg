//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication7.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HundeTabel
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Alder { get; set; }
        public Nullable<int> EjerId { get; set; }
    
        public virtual HundeEjer HundeEjer { get; set; }
    }
}