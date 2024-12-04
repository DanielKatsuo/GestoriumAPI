using GestoriumAPI.Application.UseCases.CreateClient;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestoriumAPI.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class GestoriumController(IMediator mediator) : ControllerBase
	{
		private readonly IMediator _mediator = mediator;

		[HttpPost]
		public async Task<ActionResult<CreateClientResponse>> Create (CreateClientRequest request)
		{
			var validator = new CreateClientValidator();
			var validationResult = await validator.ValidateAsync(request);
			if (!validationResult.IsValid) return BadRequest(validationResult.Errors);
			var response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
