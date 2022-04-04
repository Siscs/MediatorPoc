using MediatR;
using Poc.Mediator.Api.Domain.Commands.Response;
using System;

namespace Poc.Mediator.Api.Domain.Commands.Request
{
    public class UpdateProductRequest : IRequest<UpdateProductResponse>
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal Quantity { get; set; }
    }

    // {50511093-BA49-4606-B79A-FA222F707E86}
   
}
