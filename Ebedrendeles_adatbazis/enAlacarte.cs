//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ebedrendeles_adatbazis
{
    using System;
    using System.Collections.Generic;
    
    public partial class enAlacarte
    {
        public int alacarteID { get; set; }
        public System.DateTime datum { get; set; }
    
        public virtual enKosar enRendeles { get; set; }
        public virtual enEtelek enEtelek { get; set; }
    }
}
