using AbdullinaPZ182.Models;

namespace Test
{
    public class UserTypeTests
    {
        [Fact]
        public void IsMasterRole_ReturnsTrue_WhenUserTypeIsMaster()
        {
            var userType = new UserType { UserTypeName = "������" };

            var result = userType.IsMasterRole();

            Assert.True(result);
        }

        [Fact]
        public void IsMasterRole_ReturnsFalse_WhenUserTypeIsNotMaster()
        {
            var userType = new UserType { UserTypeName = "������" };

            var result = userType.IsMasterRole();

            Assert.False(result);
        }
    }
}