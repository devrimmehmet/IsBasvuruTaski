//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Authorize.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class Tbl_User
    {
        public int Id { get; set; }
        [DisplayName("Kullan�c� Ad�")]
        public string Username { get; set; }
        [DisplayName("Parola")]
        public string Password { get; set; }
        [DisplayName("Yetki")]
        public string Role { get; set; }
    }
}