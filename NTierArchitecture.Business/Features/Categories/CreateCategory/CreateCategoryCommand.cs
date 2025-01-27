using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using NTierArchitecture.Business.Features.Categories.CreateCategory;

namespace NTierArchitecture.Business.Features.Categories.CreateCategory;
public sealed record CreateCategoryCommand(string Name) : IRequest;
