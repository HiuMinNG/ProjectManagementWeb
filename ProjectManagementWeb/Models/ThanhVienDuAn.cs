//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagementWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThanhVienDuAn
    {
        public int DuAnID { get; set; }
        public int NguoiDungID { get; set; }
        public string VaiTro { get; set; }
        public Nullable<System.DateTime> NgayThamGia { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
    }
}
