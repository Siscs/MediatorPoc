using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Poc.Mediator.Api.Domain.Events
{
    public class ProductCreatedEvent : INotification
    {

        public Guid Id { get; set; }
        public string Message { get; set; }

        public ProductCreatedEvent()
        {
           Message = this.GetType().Name;
        }

    }
}
