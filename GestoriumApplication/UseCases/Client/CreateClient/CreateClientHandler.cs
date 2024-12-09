using AutoMapper;
using GestoriumAPI.Domain.Entities;
using GestoriumAPI.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.UseCases.Client.CreateClient
{
	public sealed class CreateClientHandler(IClientRepository clientRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateClientRequest, CreateClientResponse>
	{
		private readonly IClientRepository _clientRepository = clientRepository;
		private readonly IMapper _mapper = mapper;
		private readonly IUnitOfWork _unitOfWork = unitOfWork;

		public async Task<CreateClientResponse> Handle(CreateClientRequest request, CancellationToken cancellationToken)
		{
			var client = _mapper.Map<Client>(request);
			await _clientRepository.AddAsync(client);
			await _unitOfWork.CommitAsync();
			return _mapper.Map<CreateClientResponse>(client);
		}
	}


}
