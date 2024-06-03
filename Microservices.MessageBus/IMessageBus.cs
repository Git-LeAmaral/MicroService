using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.MessageBus
{
    public interface IMessageBus
    {
        Task PublidhMessage(object message, string topic_queue_Name);
    }
}
