using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbdullinaPZ182.Models;

namespace Test
{

    public class CommentTests
    {
        [Fact]
        public void IsMessageLengthValid_ReturnsTrue_WhenMessageIsValid()
        {
            var comment = new Comment { Message = "This is a valid message." };

            var result = comment.IsMessageLengthValid();

            Assert.True(result);
        }

        [Fact]
        public void IsMessageLengthValid_ReturnsFalse_WhenMessageExceedsMaxLength()
        {
            var longMessage = new string('a', 251);
            var comment = new Comment { Message = longMessage };

            var result = comment.IsMessageLengthValid();

            Assert.False(result);
        }
    }
}
