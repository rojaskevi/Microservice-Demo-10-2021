using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class Message
    {
        public Message(object message)
        {
            Type = message.GetType().FullName + ", " + message.GetType().Assembly.GetName().Name;
            JsonPayload = JsonConvert.SerializeObject(message);
        }

        public Message() { }

        public virtual object RecreateMessage() => JsonConvert.DeserializeObject(JsonPayload, System.Type.GetType(Type));
    }
}
