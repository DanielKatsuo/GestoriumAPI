using GestoriumAPI.Application.UseCases.Client.CreateClient;
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
			var response = await _mediator.Send(request);
			return Ok(response);
		}
	}
}
