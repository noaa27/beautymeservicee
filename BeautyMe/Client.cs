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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Review_Business = new HashSet<Review_Business>();
        }
    
        public string ID_number { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public System.DateTime birth_date { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouseNumber { get; set; }
        public string AddressCity { get; set; }
        public string password { get; set; }
    
        public virtual Future_Appointment Future_Appointment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review_Business> Review_Business { get; set; }
    }
}
