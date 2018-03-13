using System;
using System.Linq;
using WH.Promos.Test.Sdk.Clients;

namespace Web_Kafka_API_Automation.Common
{
    public class TestBase
    {
        protected static IAdminApiClient ApiClient { get; private set; }

        protected static readonly Random Random = new Random();

        protected static string RandomString(int length)
        {
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
