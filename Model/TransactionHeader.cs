//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace balaitani_psd.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionHeader()
        {
            this.TransactionDetails = new HashSet<TransactionDetail>();
        }
    
        public int id { get; set; }
        public int user_id { get; set; }
        public string status { get; set; }
        public System.DateTime transaction_date { get; set; }
        public int shipping_id { get; set; }
        public int payment_method_id { get; set; }
    
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual Shipping Shipping { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual User User { get; set; }
    }
}