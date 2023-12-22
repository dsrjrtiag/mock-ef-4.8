using Moq;
using NUnit.Framework;
using repository.Context;
using repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace repository.tests
{
    public class TestRepository
    {
        private Repository repo;
        private Mock<IRepoDbContext> mockContext;

        [SetUp]
        public void SetUp()
        {
            mockContext = new Mock<IRepoDbContext>();
            var testEntities = new List<Entity>() { new Entity() { Id = 1, Description = "Description", Name = "Name" } };
            IDbSet<Entity> mockDbSet = MockDbSetFactory.GetQueryableMockDbSet(testEntities);

            mockContext.Setup(x => x.Entities).Returns(mockDbSet);

            repo = new Repository(mockContext.Object);
        }

        [Test]
        public void TestGet()
        {
            repo.GetEntities();

            mockContext.Verify(x => x.Entities);
        }

        [Test]
        public void TestAdd()
        {
            Entity entityToAdd = new Entity() { Id = 2, Name = "Name", Description = "Description" };

            repo.AddEntity(entityToAdd);

            mockContext.Verify(x => x.Entities.Add(entityToAdd));
        }
    }
}
