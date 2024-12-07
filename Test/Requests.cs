using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbdullinaPZ182.Models;

namespace Test
{
    public class RequestTests
    {
        [Fact]
        public void IsCompleted_ReturnsTrue_WhenRequestIsCompleted()
        {
            var request = new Request
            {
                CompleteDate = DateTime.Now,
                RequestStatusId = 3
            };

            var result = request.IsCompleted();

            Assert.True(result);
        }

        [Fact]
        public void IsCompleted_ReturnsFalse_WhenRequestIsNotCompleted()
        {
            var request = new Request
            {
                CompleteDate = null,
                RequestStatusId = 3
            };

            var result = request.IsCompleted();

            Assert.False(result);
        }

        [Fact]
        public void IsCompleted_ReturnsFalse_WhenStatusIdIsNot3()
        {
            var request = new Request
            {
                CompleteDate = DateTime.Now,
                RequestStatusId = 2
            };

            var result = request.IsCompleted();

            Assert.False(result);
        }
    }
}
