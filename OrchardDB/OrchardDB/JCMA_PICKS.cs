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
    
    public partial class JCMA_PICKS
    {
        public decimal FIELD_ID { get; set; }
        public decimal BIN_ID { get; set; }
        public decimal EMP_ID { get; set; }
        public System.DateTime P_DATE { get; set; }
        public decimal WEIGHT { get; set; }
    
        public virtual JCMA_BIN JCMA_BIN { get; set; }
        public virtual JCMA_EMPLOYEE JCMA_EMPLOYEE { get; set; }
        public virtual JCMA_FIELDS JCMA_FIELDS { get; set; }
    }
}
