using Messeger.Domain.Core.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Messeger.Domain.Interfaces
{
    public interface IMessageRepository:IDisposable
    {
        IEnumerable<Message> GetMessages();
        void AddMessage(Message message);
    }
}
