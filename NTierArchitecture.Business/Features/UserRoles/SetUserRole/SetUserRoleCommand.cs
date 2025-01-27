using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace NTierArchitecture.Business.Features.UserRoles.SetUserRole;

public sealed record SetUserRoleCommand(
	Guid UserId,
	Guid RoleId) : IRequest<Unit>;
