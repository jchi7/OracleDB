//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrchardDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class JCMA_COORDINATES
    {
        public decimal FIELD_ID { get; set; }
        public decimal LONGITUDE { get; set; }
        public decimal LATITUDE { get; set; }
    
        public virtual JCMA_FIELDS JCMA_FIELDS { get; set; }
    }
}