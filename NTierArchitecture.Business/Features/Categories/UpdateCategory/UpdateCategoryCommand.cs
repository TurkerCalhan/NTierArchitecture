﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace NTierArchitecture.Business.Features.Categories.UpdateCategory;
public sealed record UpdateCategoryCommand(Guid Id, string Name) : IRequest;
