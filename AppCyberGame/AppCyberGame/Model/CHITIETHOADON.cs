//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppCyberGame.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETHOADON
    {
        public string MaHD { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
    
        public virtual DICHVU DICHVU { get; set; }
        public virtual HOADON HOADON { get; set; }
    }
}
