﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimer.Data.Repository.Factory
{
    public class RepositoriesFactory
    {
        private readonly IDbContextFactory<DataContext> _dbContextFactory;

        public RepositoriesFactory(IDbContextFactory<DataContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public AdditiveRepository CreateAdditiveRepository()
        {
            return new AdditiveRepository(_dbContextFactory);
        }
        public CompatibilityMaterialrRepository CreateCompatibilityMaterialrRepository()
        {
            return new CompatibilityMaterialrRepository(_dbContextFactory);
        }
        public UsefulProductRepository CreateUsefulProductRepository()
        {
            return new UsefulProductRepository(_dbContextFactory);
        }
        public MaterialRepository CreateMaterialRepository()
        {
            return new MaterialRepository(_dbContextFactory);
        }
        public PropertyMaterialRepository CreatePropertyMaterialRepository()
        {
            return new PropertyMaterialRepository(_dbContextFactory);
        }
        public PropertyUsefulProductRepository CreatePropertyUsefulProductRepository()
        {
            return new PropertyUsefulProductRepository(_dbContextFactory);
        }
        public PropertyRepository CreatePropertyRepository()
        {
            return new PropertyRepository(_dbContextFactory);
        }
        public RecipeRepository CreateRecipeRepository()
        {
            return new RecipeRepository(_dbContextFactory);
        }
        public UnitRepository CreateUnitRepository()
        {
            return new UnitRepository(_dbContextFactory);
        }
        public UserRepository CreateUserRepository()
        {
            return new UserRepository(_dbContextFactory);
        }
        public PropertyAdditiveRepository CreatePropertyAdditiveRepository()
        {
            return new PropertyAdditiveRepository(_dbContextFactory);
        }
    }
}
