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
    
    public partial class DICHVU
    {
        public DICHVU()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }
    
        public string MaDV { get; set; }
        public string TenDV { get; set; }
        public Nullable<int> GiaDV { get; set; }
        public string LoaiDV { get; set; }
        public string MoTaDV { get; set; }
        public string HinhAnh { get; set; }
        public string SoTonKho { get; set; }
    
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
    }
}
