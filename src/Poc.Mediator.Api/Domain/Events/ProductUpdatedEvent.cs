using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Mediator.Api.Domain.Events
{
    public class ProductUpdatedEvent : INotification
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public ProductUpdatedEvent()
        {
            Message = this.GetType().Name;
        }
    }
}
