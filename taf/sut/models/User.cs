using mentoring_taf.taf.actions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace mentoring_taf.taf.sut.models
{
    public class User
    {
        public String UserId { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

    }
}
