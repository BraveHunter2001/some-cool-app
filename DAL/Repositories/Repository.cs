namespace DAL.Repositories;

internal abstract class Repository<TEntity>(Context.SomeCoolContext context) where TEntity : class
{
    internal void Create(TEntity entity)
    {
        context.Add(entity);
        context.SaveChanges();
    }

    internal TEntity? GetById(int id) => context.Find<TEntity>([id]);

    internal void Insert(TEntity entity)
    {
        context.Update(entity);
        context.SaveChanges();
    }

    internal void Delete(TEntity entity)
    {
        context.Remove(entity);
        context.SaveChanges();
    }
}