﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoriumAPI.Application.UseCases.CreateClient
{
	public sealed class CreateClientValidator : AbstractValidator<CreateClientRequest>
	{
		public CreateClientValidator()
		{
			RuleFor(x => x.Costumer).NotEmpty().WithMessage("Costumer is required").MinimumLength(3).MaximumLength(50);
			RuleFor(x => x.CostumerPhone).NotEmpty().WithMessage("CostumerPhone is required").MaximumLength(11);
		}
	}
}