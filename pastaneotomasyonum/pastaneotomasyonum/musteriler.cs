//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace otomasyon2yedek
{
    using System;
    using System.Collections.Generic;
    
    public partial class musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public musteriler()
        {
            this.satislar = new HashSet<satislar>();
        }
    
        public int musteriid { get; set; }
        public string musteriad { get; set; }
        public string musterisoyad { get; set; }
        public string musteritel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<satislar> satislar { get; set; }
    }
}