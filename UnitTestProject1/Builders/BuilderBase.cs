using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Kafka_API_Automation.Builders
{
    public abstract class BuilderBase<T>
    {
        private readonly T _entity;

        protected static readonly Random Random = new Random();

        protected BuilderBase(T entity)
        {
            _entity = entity;
        }

        protected T Entity => _entity;

        public T Build()
        {
            return _entity;
        }

        protected static string RandomString(int length)
        {
            const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(Chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
