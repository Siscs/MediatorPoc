using Poc.Mediator.Api.Domain.Commands.Request;
using Poc.Mediator.Api.Domain.Commands.Response;
using System;
using MediatR;
using System.Threading.Tasks;
using System.Threading;
using Poc.Mediator.Api.Domain.Events;
using Microsoft.Extensions.Logging;

namespace Poc.Mediator.Api.Domain.CommandHandlers
{
    public class UpdateProductHandler: IRequestHandler<UpdateProductRequest, UpdateProductResponse>
    {
        private readonly ILogger<UpdateProductHandler> _logger;
        private readonly IMediator _mediator;

        public UpdateProductHandler(ILogger<UpdateProductHandler> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<UpdateProductResponse> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {

            _logger.LogInformation("Handle update product");

            var result = new UpdateProductResponse
            {
                Id = request.Id,
                Description = request.Description + " updated",
                Quantity = request.Quantity,
                Value = request.Value
            };

            // event
            await _mediator.Publish(new ProductUpdatedEvent { Id = request.Id } );

            return await Task.FromResult(result);

        }
    }
}
