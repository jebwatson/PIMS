using System;
using System.Collections.Generic;
using System.Text;

namespace DBI
{
    public class Users
    {
        private int _unassigned = -1;

        public int userId { get; set; }
        public string nameLast { get; set; }
        public string nameFirst { get; set; }
        public string title { get; set; }
        public int accessLevel { get; set; }
        public string username { get; set; }

        public Users()
        {
            userId = _unassigned;
            nameLast = string.Empty;
            nameFirst = string.Empty;
            title = string.Empty;
            accessLevel = _unassigned;
            username = string.Empty;
        }

        public Users(string nameLast, string nameFirst, string title, int accessLevel, string username, int userId)
        {
            this.nameLast = nameLast;
            this.nameFirst = nameFirst;
            this.title = title;
            this.accessLevel = accessLevel;
            this.username = username;
            this.userId = userId;
        }
    }
}
