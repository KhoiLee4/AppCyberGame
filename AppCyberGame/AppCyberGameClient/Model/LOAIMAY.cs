//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppCyberGameClient.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAIMAY
    {
        public LOAIMAY()
        {
            this.MAYs = new HashSet<MAY>();
        }
    
        public string MaLM { get; set; }
        public string TenLM { get; set; }
        public Nullable<int> Gia { get; set; }
        public string CauHinh { get; set; }
    
        public virtual ICollection<MAY> MAYs { get; set; }
    }
}
