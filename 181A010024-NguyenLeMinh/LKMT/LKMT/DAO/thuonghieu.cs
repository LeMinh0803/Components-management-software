//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class thuonghieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thuonghieu()
        {
            this.sanphams = new HashSet<sanpham>();
        }
    
        public int id_thuonghieu { get; set; }
        public string id_nhom { get; set; }
        public string tenthuonghieu { get; set; }
        public System.DateTime ngaytao { get; set; }
        public System.DateTime ngaycapnhat { get; set; }
    
        public virtual nhomsanpham nhomsanpham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sanpham> sanphams { get; set; }
    }
}
