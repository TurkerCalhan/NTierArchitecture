﻿using AutoMapper;
using MediatR;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.Business.Features.Categories.CreateCategory;

internal sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand>
{
	private readonly ICategoryRepository _categoryRepository;
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper)
	{
		_categoryRepository = categoryRepository;
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
	{
		var isCategoryNameExist = await _categoryRepository.AnyAsync(p => p.Name == request.Name, cancellationToken);
		if (isCategoryNameExist)
		{
			throw new ArgumentException("Bu kategori daha önce oluşturulmuş.");
		}
		Category category = _mapper.Map<Category>(request);
		await _categoryRepository.AddAsync(category, cancellationToken);
		await _unitOfWork.SaveChangesAsync(cancellationToken);
	}
}
