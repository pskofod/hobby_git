//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HobbyKlub
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public Member()
        {
            this.Location = new HashSet<Location>();
        }
    
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneMobile { get; set; }
        public string Email1 { get; set; }
        public Nullable<int> LoenNumber { get; set; }
        public string City { get; set; }
        public Nullable<int> Zip { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneHome { get; set; }
        public string Email2 { get; set; }
        public int Permissions { get; set; }
        public bool Active { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual ICollection<Location> Location { get; set; }
    }
}
