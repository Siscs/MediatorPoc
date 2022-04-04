using MediatR;
using Microsoft.Extensions.Logging;
using Poc.Mediator.Api.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Poc.Mediator.Api.Domain.EventsHandlers
{
    public class ProductCreatedEventHandler : INotificationHandler<ProductCreatedEvent>
    {
        private readonly ILogger<ProductCreatedEventHandler> _logger;

        public ProductCreatedEventHandler(ILogger<ProductCreatedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(ProductCreatedEvent notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => { 
                _logger.LogInformation(new string('=', 100));
                _logger.LogInformation($"Evento: {notification.Id} - {notification.Message} ");
                _logger.LogInformation(new string('=', 100));
            });
        }
    }

}
