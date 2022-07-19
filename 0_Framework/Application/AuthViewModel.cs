using System.Collections.Generic;

namespace _0_Framework.Application
{
    public class AuthViewModel
    {
        public long Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string ProfilePhoto { get; set; }
        public long RoleId { get; set; }
        public string Role { get; set; }
        public List<int> Permissions { get; set; }


        public AuthViewModel()
        {
        }

        public AuthViewModel(long id, string fname, string lname, string username, string profilePhoto, long roleId, List<int> permissions)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            Username = username;
            ProfilePhoto = profilePhoto;
            RoleId = roleId;
            Permissions = permissions;
        }
    }
}