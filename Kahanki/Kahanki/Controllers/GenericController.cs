using Kahanki.Data;
using Kahanki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kahanki.Controllers;

public class GenericController<TEntity> : ControllerBase where TEntity : class, IEntity
{
    private readonly ApplicationDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    public GenericController(ApplicationDbContext db)
    {
        _dbContext = db;
        _dbSet = _dbContext.Set<TEntity>();
    }

    [HttpPost]
    public TEntity Create(TEntity entity)
    {
        _dbSet.Add(entity);
        _dbContext.SaveChanges();

        return _dbSet.Single(c => c.Id == entity.Id);
    }

    [HttpGet]
    public TEntity Read(string id)
    {
        return _dbSet.Single(c => c.Id == id);
    }

    [HttpPost]
    public TEntity Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _dbContext.SaveChanges();

        return _dbSet.Single(c => c.Id == entity.Id);
    }

    [HttpPost]
    public void Delete(string id)
    {
        var entity = _dbSet.FirstOrDefault(r => r.Id == id);
        _dbSet.Remove(entity);

        _dbContext.SaveChanges();
    }

    [HttpGet]
    public IEnumerable<TEntity> GetAll()
    {
        return _dbSet.ToList();
    }
}