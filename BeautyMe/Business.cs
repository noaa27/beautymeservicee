//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautyMe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Business
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Business()
        {
            this.Business_can_give_treatment = new HashSet<Business_can_give_treatment>();
            this.Review_Business = new HashSet<Review_Business>();
        }
    
        public string Business_Number { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Is_client_house { get; set; }
        public string Professional_ID_number { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Business_can_give_treatment> Business_can_give_treatment { get; set; }
        public virtual Professional Professional { get; set; }
        public virtual Professional Professional1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review_Business> Review_Business { get; set; }
    }
}
