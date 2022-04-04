using MediatR;
using Microsoft.Extensions.Logging;
using Poc.Mediator.Api.Domain.Events;
using System.Threading;
using System.Threading.Tasks;

namespace Poc.Mediator.Api.Domain.EventsHandlers
{
    public class ProductUpdatedEventHandler : INotificationHandler<ProductUpdatedEvent>
    {
        private readonly ILogger<ProductUpdatedEventHandler> _logger;

        public ProductUpdatedEventHandler(ILogger<ProductUpdatedEventHandler> logger)
        {
            _logger = logger;
        }

        public Task Handle(ProductUpdatedEvent notification, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                _logger.LogInformation(new string('=', 100));
                _logger.LogInformation($"Evento: {notification.Id} - {notification.Message} ");
                _logger.LogInformation(new string('=', 100));
            });
        }
    }

}
