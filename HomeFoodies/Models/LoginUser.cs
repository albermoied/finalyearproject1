//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HomeFoodies.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoginUser
    {
        public LoginUser()
        {
            this.Suppliers = new HashSet<Supplier>();
        }
    
        public int UserID { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public int CurrentStatusID { get; set; }
        public string VerificationCode { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual StatusCode StatusCode { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}