﻿using Microsoft.EntityFrameworkCore;
using SchedulePatients.Domain.Models;

namespace SchedulePatients.Domain.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(int id);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
