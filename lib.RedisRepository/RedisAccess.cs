using System;
using StackExchange.Redis;

namespace lib.RedisRepository.Access
{
    public class RedisAccess
    {
        private readonly ConnectionMultiplexer ConnectionRedis = ConnectionMultiplexer.Connect("localhost:6379");
        private IDatabase ClientRedis {get; set;}
        public RedisAccess()
        {
            this.ClientRedis = ConnectionRedis.GetDatabase();
        }
        public void CreateNewKeyValue(string key, string value)
        {
            ClientRedis.StringSet(key, value);
        }
        public string ReadKeyValue(string key)
        {
            var response = ClientRedis.StringGet(key);
            return response.ToString();
        }
    }
}