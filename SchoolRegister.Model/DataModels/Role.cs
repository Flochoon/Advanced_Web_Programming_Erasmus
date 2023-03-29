using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {   
        public RoleValue RoleValue { get; set; } = default!;
        public string Name { get; }
        public IList<SubjectGroup> SubjectGroups { get; set; } = default!;
    
        public Role(String name, RoleValue roleValue){
            this.RoleValue = roleValue;
            this.Name = name;
        }
    }



}