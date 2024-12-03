using AutoMapper;
using GestoriumAPI.Domain.Entities;
using GestoriumAPI.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.UseCases.CreateClient
{
	public sealed class CreateClientHandler(IClientRepository clientRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<CreateClientRequest, CreateClientResponse>
	{
		private readonly IClientRepository _clientRepository = clientRepository;
		private readonly IMapper _mapper = mapper;
		private readonly IUnitOfWork _unitOfWork = unitOfWork;

		public async Task<CreateClientResponse> Handle(CreateClientRequest request, CancellationToken cancellationToken)
		{
			var user = _mapper.Map<Client>(request);
			await _clientRepository.AddAsync(user);
			await _unitOfWork.CommitAsync();
			return _mapper.Map<CreateClientResponse>(user);
		}
	}
}
