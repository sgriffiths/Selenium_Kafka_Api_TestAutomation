using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Kafka_API_Automation.Builders
{
    public class Builder
    {
        public static CreateAccountBuilder CreateAccount => CreateAccountBuilder.New();
    }
}
