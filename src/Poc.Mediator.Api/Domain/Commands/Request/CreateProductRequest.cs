using MediatR;
using Poc.Mediator.Api.Domain.Commands.Response;

namespace Poc.Mediator.Api.Domain.Commands.Request
{
    public class CreateProductRequest : IRequest<CreateProductResponse>
    {
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal Quantity { get; set; }
    }

    // {50511093-BA49-4606-B79A-FA222F707E86}


}
