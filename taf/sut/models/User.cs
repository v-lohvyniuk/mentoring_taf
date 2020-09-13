using mentoring_taf.taf.actions;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace mentoring_taf.taf.sut.models
{
    public class User
    {
        private String login;
        private String password;
        private String firstName;
        private String lastName;

        public String GetLogin()
        {
            return login;
        }

        public String GetPassword()
        {
            return password;
        }

        public String GetFirstName()
        {
            return firstName;
        }

        public String GetLastName()
        {
            return lastName;
        }

        public User(String login, String password, String firstName, String lastName)
        {
            this.login = login;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }
}
