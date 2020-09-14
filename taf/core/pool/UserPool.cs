using mentoring_taf.taf.core.readers;
using mentoring_taf.taf.sut.models;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace mentoring_taf.taf.core.pool
{
    class UserPool
    {
        private UserPool() { }

        public static List<User> users;
        
        public static User getOne()
        {
            if (users == null)
            {
                FetchUsers();
            }
            return users[0];
        }
        
        public static List<User> getAll()
        {
            if (users == null)
            {
                FetchUsers();
            }
            return users;
        }

        private static void FetchUsers()
        {
            users = new UsersCsvDataSourceReader().ReadAll();
        }
        
    }
}
