using lib.RedisRepository.Access;
using NUnit.Framework;

namespace lib.RedisRepository.Test
{
    [TestFixture]
    public class RedisAccessTest
    {
        RedisAccess access = new RedisAccess();
        
        [Test]
        public void ReadKeyValue_Test()
        {
            access.CreateNewKeyValue("test","is important");
            var response = access.ReadKeyValue("test");

            Assert.AreEqual("is important", response);
        }
    }
}