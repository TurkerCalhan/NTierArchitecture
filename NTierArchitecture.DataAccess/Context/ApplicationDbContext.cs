﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Context
{
	internal sealed class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, Guid>, IUnitOfWork
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Ignore<IdentityUserClaim<Guid>>();
			builder.Ignore<IdentityUserLogin<Guid>>();
			builder.Ignore<IdentityUserRole<Guid>>();
			builder.Ignore<IdentityUserToken<Guid>>();
			builder.Ignore<IdentityRoleClaim<Guid>>();

			builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
		}
	}
}
