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
    
    public partial class LD30Attribute
    {
        public int AttributeID { get; set; }
        public int TableID { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public string DisplayLabel { get; set; }
        public string Deleted { get; set; }
        public string GUIField { get; set; }
        public string Formula { get; set; }
        public string AttributeRole { get; set; }
        public string Expression { get; set; }
        public Nullable<int> Length { get; set; }
        public string IsOrder { get; set; }
    
        public virtual LDTABLE LDTABLE { get; set; }
        public virtual LD30LinkedAttribute LD30LinkedAttribute { get; set; }
    }
}
