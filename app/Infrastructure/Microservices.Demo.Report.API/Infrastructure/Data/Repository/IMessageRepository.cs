
namespace Microservices.Demo.Report.API.Infrastructure.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
    public interface IMessageRepository
    {
        void Add(Message message);
        IList<Message> FetchPendingMessages(int count);
    }
}
