﻿using Microsoft.EntityFrameworkCore;
using Polimer.Data.Models;
using Polimer.Data.Repository.Abstract;

namespace Polimer.Data.Repository;

public class PropertyMaterialRepository : RepositoryBase<PropertyMaterialEntity>
{
    public PropertyMaterialRepository(IDbContextFactory<DataContext> dbContextFactory) : base(dbContextFactory)
    {
    }

}