//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tavi.BoMayToChuc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhongBan
    {
        public int PhongBanId { get; set; }
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public Nullable<int> ThuocCoQuanId { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string QuyetDinhThanhLap { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> ThuTuUuTien { get; set; }
        public Nullable<bool> ConHoatDong { get; set; }
        public Nullable<bool> LaPhongBanPhatSinh { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<int> CanBoTaoId { get; set; }
        public Nullable<bool> DaXoa { get; set; }
        public Nullable<int> CanBoXoaId { get; set; }
    }
}