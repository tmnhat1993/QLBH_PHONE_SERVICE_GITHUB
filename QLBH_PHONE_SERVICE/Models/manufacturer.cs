//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBH_PHONE_SERVICE.Models
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    [KnownType(typeof(import_bill))]
    [KnownType(typeof(product))]
    
    public partial class manufacturer
    {
        public manufacturer()
        {
            this.import_bill = new HashSet<import_bill>();
            this.products = new HashSet<product>();
        }
    
    	[DataMember]
        public int id { get; set; }
    	[DataMember]
        public string name { get; set; }
    	[DataMember]
        public string phone_number { get; set; }
    	[DataMember]
        public string address { get; set; }
    
    	[DataMember]
        public virtual ICollection<import_bill> import_bill { get; set; }
    	[DataMember]
        public virtual ICollection<product> products { get; set; }
    }
}
