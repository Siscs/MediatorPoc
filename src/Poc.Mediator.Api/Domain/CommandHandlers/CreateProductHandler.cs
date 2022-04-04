using Poc.Mediator.Api.Domain.Commands.Request;
using Poc.Mediator.Api.Domain.Commands.Response;
using System;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Poc.Mediator.Api.Domain.Events;
using Microsoft.Extensions.Logging;

namespace Poc.Mediator.Api.Domain.CommandHandlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
    {
        private readonly ILogger<CreateProductHandler> _logger;
        private readonly IMediator _mediator;

        public CreateProductHandler(ILogger<CreateProductHandler> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handle create product");

            var result = new CreateProductResponse
            {
                Id = Guid.NewGuid()
            };

            // event
            await _mediator.Publish(new ProductCreatedEvent { Id = result.Id });

            return await Task.FromResult(result);        }
    }
}
