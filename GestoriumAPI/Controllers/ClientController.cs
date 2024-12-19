using GestoriumAPI.Application.Shared.UseCases.Client.CreateClient;
using GestoriumAPI.Application.Shared.UseCases.Client.UpdateClient;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestoriumAPI.Controllers
{
	[Route("/[controller]")]
	[ApiController]
	public class ClientController(IMediator mediator) : ControllerBase
	{
		private readonly IMediator _mediator = mediator;

		[HttpPost]
		public async Task<ActionResult<CreateClientResponse>> Create(CreateClientRequest request)
		{
			var response = await _mediator.Send(request);
			return Ok(response);
		}

		[HttpPut]
		public async Task<ActionResult<UpdateClientResponse>> Update(UpdateClientRequest request)
		{
			var response = await _mediator.Send(request);
			return Ok(response);
		}

	}
}
