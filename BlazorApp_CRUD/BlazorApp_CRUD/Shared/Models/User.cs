using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp_CRUD.Shared.Models
{
    public class User
    {
        public int Userid { get; set; }

        public string Username { get; set; }

        public string Address { get; set; }

        public string Phonenumber { get; set; }

        public string Emailid { get; set; }
    }
}
