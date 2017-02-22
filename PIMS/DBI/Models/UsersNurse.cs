using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class UsersNurse
    {
        private int _unassigned = -1;

        public int userId { get; set; }
        public string nameLast { get; set; }
        public string nameFirst { get; set; }
        public string title { get; set; }
        public string accessLevel { get; set; }

        public UsersNurse()
        {
            userId = _unassigned;
            nameLast = string.Empty;
            nameFirst = string.Empty;
            title = string.Empty;
            accessLevel = string.Empty;
        }

        public UsersNurse(int id, string nameLast, string nameFirst, string title, string accessLevel)
        {
            userId = id;
            this.nameLast = nameLast;
            this.nameFirst = nameFirst;
            this.title = title;
            this.accessLevel = accessLevel;

        }
    }
}
