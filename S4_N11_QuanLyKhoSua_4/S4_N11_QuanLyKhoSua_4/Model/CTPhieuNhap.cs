//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S4_N11_QuanLyKhoSua_4.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTPhieuNhap
    {
        public Nullable<int> SLNhap { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public string MaPN { get; set; }
        public string MaSP { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
