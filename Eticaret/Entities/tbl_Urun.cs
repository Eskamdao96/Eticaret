//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eticaret.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Urun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Urun()
        {
            this.SiparisDetay = new HashSet<SiparisDetay>();
            this.tbl_Favori = new HashSet<tbl_Favori>();
            this.tbl_Sepet = new HashSet<tbl_Sepet>();
            this.tbl_Yildiz = new HashSet<tbl_Yildiz>();
            this.tbl_Yorum = new HashSet<tbl_Yorum>();
        }
    
        public int Urun_Id { get; set; }
        public string Urun_Adi { get; set; }
        public Nullable<int> Stok { get; set; }
        public string Seri_No { get; set; }
        public string Aciklama { get; set; }
        public int Kategori_ID { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<decimal> Indirim_Oranı { get; set; }
        public Nullable<int> Marka_ID { get; set; }
        public string Resim_URL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDetay> SiparisDetay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Favori> tbl_Favori { get; set; }
        public virtual tbl_Kategori tbl_Kategori { get; set; }
        public virtual tbl_Marka tbl_Marka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Sepet> tbl_Sepet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Yildiz> tbl_Yildiz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Yorum> tbl_Yorum { get; set; }
    }
}
