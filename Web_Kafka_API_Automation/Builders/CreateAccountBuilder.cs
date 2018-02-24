using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WH.Domain.Model.Account;
using WH.Promos.Test.Sdk.Builders;

namespace Web_Kafka_API_Automation.Builders
{
    public class CreateAccountBuilder : BuilderBase<AddAccount>
    {
        private CreateAccountBuilder(AddAccount message) : base(message)
        {
        }
        public static CreateAccountBuilder New()

        {
            var random = Guid.NewGuid().ToString().Substring(1, 12);
            var message = new AddAccount();
            {
                message.Title = "Mr";
                message.Username = random;
                message.Password = "password";
                message.FirstName = "Test" + random;
                message.MiddleName = "T";
                message.LastName = "Test" + random;
                message.DateOfBirth = new DateTime(1980, 1, 1);
                message.Addresses = new List<Address>
                {
                    new Address
                    {
                        Country = "Australia",
                        Postcode = "4220",
                        State = "NSW",
                        Street1 = "9999 Park Street",
                        Street2 = string.Empty,
                        Suburb = "Sydney",
                        AddressType = AddressType.Home
                    }
                };
                message.Contact = new Contact
                {
                    Email = random + "@test.com",
                    Mobile = "0400440440",
                    Telephone = "0290000000",
                    Contactable = "Y",
                    PartnerContactable = "Y"
                };
                message.CompetitionOnly = true;
            }
            ;
            {
            }
            return new CreateAccountBuilder(message);

        }

        public CreateAccountBuilder WithFirstName(string firstName)
        {
            Entity.FirstName = firstName;

            return this;
        }
        public CreateAccountBuilder WithLastName(string lastName)
        {
            Entity.LastName = lastName;

            return this;
        }
        public CreateAccountBuilder WithUserName(string userName)
        {
            Entity.LastName = userName;

            return this;
        }
    }
}

