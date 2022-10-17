using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientMDA.ViewModels
{
    public class CMemberDemoViewModel
    {
        public int MemberID { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string L_Name { get; set; }
        public string F_Name { get; set; }
        public string NickName { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public int Bonus { get; set; }
        public bool Formal { get; set; }
        public int Permission { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
