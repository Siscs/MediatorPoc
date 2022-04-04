using System;

namespace Poc.Mediator.Api.Domain.Commands.Response
{
    public class UpdateProductResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public decimal Quantity { get; set; }
    }
}
