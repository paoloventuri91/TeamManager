using System;
using NUnit.Framework;
using Repository;
using Repository.DataModels;

namespace RepositoryTest
{
    public class UnitTest1
    {
        #region Fields
        private RepositoryManager _rm;
        #endregion

        [SetUp]
        public void SetUp()
        {
            Assert.DoesNotThrow(() => _rm = new RepositoryManager());
        }
        
        [TearDown]
        public void TearDown()
        {
            Assert.DoesNotThrow(() => _rm.Dispose());
        }

        [Test]
        public void TestMethod1()
        {
            var player = new Player
            {
                Name = "Gigio",
                Surname = "Gigi",
                BirthDate = new DateTime(2020, 12, 25)
            };

            Assert.DoesNotThrow(() => _rm.Insert(player));
        }

        [Test]
        public void TestMethod2()
        {
            Player player = null;

            Assert.DoesNotThrow(() => _rm = new RepositoryManager());
            Assert.DoesNotThrow(() => player = _rm.FindById<Player>(1));

            Assert.IsNotNull(player);
            Assert.AreEqual("Gigio", player.Name);
            Assert.AreEqual("Gigi", player.Surname);
            Assert.AreEqual(new DateTime(2020, 12, 25), player.BirthDate);
        }
    }
}
