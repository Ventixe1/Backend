using Persistence.Entities;
using Persistence.Models;
using System.Linq.Expressions;

namespace Persistence.Repositories
{
    public interface IEventRepository
    {
        Task<RepositoryResult<IEnumerable<EventEntity>>> GetAllAsync(EventEntity entity);
        Task<RepositoryResult<EventEntity?>> GetAsync(Expression<Func<EventEntity, bool>> expression);
    }
}