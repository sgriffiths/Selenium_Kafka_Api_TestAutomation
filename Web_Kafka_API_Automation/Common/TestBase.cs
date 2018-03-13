using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WH.Promos.Test.Sdk.Clients;

namespace Web_Kafka_API_Automation.Common
{
    [TestClass]
    public class TestBase
    {
        protected static IAdminApiClient ApiClient { get; private set; }

        protected static readonly Random Random = new Random();

        protected static string RandomString(int length)
        {
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }
        [AssemblyCleanup]
        public static void TestBaseAssemblyCleanup()
        {
            //BetsTopic?.Flush();
            //PaymentsTopic?.Flush();
            //IntercomTopic?.Flush();
        }
    }
}
