//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demo1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TinTuc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TinTuc()
        {
            this.AnhTins = new HashSet<AnhTin>();
        }
    
        public string MaTin { get; set; }
        public string Anh { get; set; }
        public System.DateTime NgayDang { get; set; }
        public string MaNV { get; set; }
        public string MoTa { get; set; }
        public string Noi_Dung { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AnhTin> AnhTins { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}