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
    
    public partial class LD3Method
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string InternalName { get; set; }
        public int ObjectTypeID { get; set; }
        public string Deleted { get; set; }
        public string MethodType { get; set; }
        public Nullable<int> ReturnType { get; set; }
        public string ReturnList { get; set; }
        public string ListColumn { get; set; }
    
        public virtual LDOBJECTTYPE LDOBJECTTYPE { get; set; }
    }
}
