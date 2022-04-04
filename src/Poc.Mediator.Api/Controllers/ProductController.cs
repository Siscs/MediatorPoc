using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poc.Mediator.Api.Domain.Commands.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poc.Mediator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet]
        [Route("id:Guid")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            return await Task.FromResult(Ok(new { id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProducts(CreateProductRequest request)
        {
            var result = await _mediator.Send(request);

            return await Task.FromResult(Ok(result));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProducts(UpdateProductRequest request)
        {

            var result = await _mediator.Send(request);

            return await Task.FromResult(Ok(result));
        }
    }

    // {50511093-BA49-4606-B79A-FA222F707E86}


}
