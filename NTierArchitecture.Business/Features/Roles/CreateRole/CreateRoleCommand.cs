using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace NTierArchitecture.Business.Features.Roles.CreateRole;

public sealed record CreateRoleCommand(
	string Name) : IRequest<Unit>;
