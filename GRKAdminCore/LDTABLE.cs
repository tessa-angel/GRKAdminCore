//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GRKAdminCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class LDTABLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LDTABLE()
        {
            this.LD30Attribute = new HashSet<LD30Attribute>();
            this.LDOBJECTTYPE = new HashSet<LDOBJECTTYPE>();
            this.LDOBJECTTYPE1 = new HashSet<LDOBJECTTYPE>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string CardTable { get; set; }
        public string GUIView { get; set; }
        public string Type { get; set; }
        public string DisplayLabel { get; set; }
        public string Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LD30Attribute> LD30Attribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LDOBJECTTYPE> LDOBJECTTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LDOBJECTTYPE> LDOBJECTTYPE1 { get; set; }
    }
}
