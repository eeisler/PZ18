using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbdullinaPZ182.Models;

namespace Test
{
    public class UserTests
    {
        [Fact]
        public void IsPhoneValid_ReturnsTrue_WhenPhoneIsValid()
        {
            var user = new User { Phone = "1234567890" };

            var result = user.IsPhoneValid();

            Assert.True(result);
        }

        [Fact]
        public void IsPhoneValid_ReturnsFalse_WhenPhoneIsInvalid()
        {
            var user = new User { Phone = "12345abcde" };

            var result = user.IsPhoneValid();

            Assert.False(result);
        }

        [Fact]
        public void IsPhoneValid_ReturnsFalse_WhenPhoneLengthIsNot10()
        {
            var user = new User { Phone = "123456" };

            var result = user.IsPhoneValid();

            Assert.False(result);
        }
    }
}
