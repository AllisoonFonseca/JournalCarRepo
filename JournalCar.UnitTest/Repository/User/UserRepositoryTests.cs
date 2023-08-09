using JournalCar.API.Controllers;
using JournalCar.API.Data;
using JournalCar.API.Model.Domain;
using JournalCar.API.Repository.User;
using JournalCar.UnitTest.Data;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalCar.UnitTest.Repository.User
{
    public class UserRepositoryTests
    {

        Mock<JournalCarDbContext> dbContext = new Mock<JournalCarDbContext>();

        [Fact]
        public async void GetAll_Succeed()
        {
            // Arrange
            IUserRepository userRepository = new UserRepository(dbContext.Object);
            dbContext.Setup(x=> x.User).ReturnsDbSet(TestDataHelper.GetFakeUsersList());

            // Act
            List<Users> users = await userRepository.GetAll();

            //Assert

            Assert.NotNull(users);
            Assert.Equal(3, users.Count);
        }

    }
}
