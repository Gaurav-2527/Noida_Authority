﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noida.Authority.Repository.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        public Nullable<int> RegistrationId { get; set; }
        public string PropertyId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string Sector { get; set; }
        public string Block { get; set; }
        public string PlotNo { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsLocked { get; set; }
        public Nullable<bool> IsFirstTimeActivated { get; set; }
        public Nullable<System.DateTime> PasswordChangeDate { get; set; }
        public string IdFileName { get; set; }
        public string IdFileType { get; set; }
        public string PropertyFileName { get; set; }
        public string PropertyFileType { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public string Remarks { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
