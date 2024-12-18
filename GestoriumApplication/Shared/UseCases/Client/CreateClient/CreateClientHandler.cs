using AutoMapper;
using GestoriumAPI.Domain.Entities;
using GestoriumAPI.Domain.Entities.Clients;
using GestoriumAPI.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.Shared.UseCases.Client.CreateClient
{
	public sealed class UpdateClientHandler(IClientRepository clientRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateClientRequest, UpdateClientResponse>
	{
		private readonly IClientRepository _clientRepository = clientRepository;
		private readonly IMapper _mapper = mapper;
		private readonly IUnitOfWork _unitOfWork = unitOfWork;

		public async Task<UpdateClientResponse> Handle(UpdateClientRequest request, CancellationToken cancellationToken)
		{
			var client = _mapper.Map<ClientInfo>(request);
			await _clientRepository.AddAsync(client);
			await _unitOfWork.CommitAsync();
			return _mapper.Map<UpdateClientResponse>(client);
		}
	}


}
