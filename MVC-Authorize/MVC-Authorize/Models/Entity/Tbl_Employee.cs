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
    using System.ComponentModel.DataAnnotations;

    public partial class Tbl_Employee
    {
        public int Id { get; set; }
        [DisplayName("Departman")]
        public Nullable<int> Department_Id { get; set; }
        [DisplayName("Ad�")]
        public string Name { get; set; }
        [DisplayName("Soyad�")]
        public string Surname { get; set; }
        [DisplayName("Do�um Tarihi")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [DisplayName("Cinsiyeti")]
        public string Gender { get; set; }
        [DisplayName("Evli Mi?")]
        public Nullable<bool> IsMarried { get; set; }

        public virtual Tbl_Department Tbl_Department { get; set; }
    }
}