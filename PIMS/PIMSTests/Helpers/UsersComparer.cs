using DBI;
using NUnit.Framework;

namespace PIMSTests.Helpers
{
    class UsersComparer : ICompare<Users>
    {
        public void Compare(Users user1, Users user2)
        {
            Assert.That(user1.userId, Is.EqualTo(user2.userId));
            Assert.That(user1.nameLast, Is.EqualTo(user2.nameLast));
            Assert.That(user1.nameFirst, Is.EqualTo(user2.nameFirst));
            Assert.That(user1.title, Is.EqualTo(user2.title));
            Assert.That(user1.accessLevel, Is.EqualTo(user2.accessLevel));
            Assert.That(user1.username, Is.EqualTo(user2.username));
        }
    }
}
