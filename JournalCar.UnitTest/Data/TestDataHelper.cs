using JournalCar.API.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalCar.UnitTest.Data
{
    public class TestDataHelper
    {
        public static List<Users> GetFakeUsersList()
        {
            return new List<Users>()
            {
                new Users()
                {
                    Id = new Guid("8c7e62aa-b6f0-4e38-9282-62268767ddd1"), 
                    TypeDocId = new Guid("8c440691-1b5f-446a-94a6-35fe44a54e64"),
                    Id_Number = "1024157484",
                    FirstName = "Allison",
                    Surname = "Fonseca",
                    Email = "allison@fonseca.com",
                    Password = "allison123",
                    IsActive = true
                },
                new Users()
                {
                    Id = new Guid("a69cf24f-a380-4cb0-ba04-125d79ff7e82"),
                    TypeDocId = new Guid("8c440691-1b5f-446a-94a6-35fe44a54e64"),
                    Id_Number = "51248963",
                    FirstName = "Jimmy",
                    Surname = "Velasquez",
                    Email = "jimmy@gmail.com",
                    Password = "jimmy456",
                    IsActive = true
                },
                new Users()
                {
                    Id = new Guid("3f6b2ab5-1d3f-45b8-b44d-7f984780a1b6"),
                    TypeDocId = new Guid("035dd0f4-d9a1-4c50-97e3-6d1287b1ad63"),
                    Id_Number = "79541287",
                    FirstName = "Jorge",
                    Surname = "Ramirez",
                    Email = "jorge@outlook.com",
                    Password = "george789",
                    IsActive = true
                },
            };
        }

        public static List<TypeDoc> GetFakeTypeDocList()
        {
            return new List<TypeDoc>()
            {
                new TypeDoc()
                {
                    Id = new Guid("8c440691-1b5f-446a-94a6-35fe44a54e64"),
                    Name = "Cédula de ciudadania",
                    Code = "CC"
                },
                new TypeDoc()
                {
                    Id = new Guid("035dd0f4-d9a1-4c50-97e3-6d1287b1ad63"),
                    Name = "Cédula de extranjeria",
                    Code = "CE"
                }
            };
        }
    }
}
