//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIUser.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public System.Guid Id { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public System.DateTime lastLogin { get; set; }
        public System.DateTime dob { get; set; }
        public System.DateTime createOn { get; set; }
        public System.DateTime modifiedOn { get; set; }
        public string status { get; set; }
    }
}