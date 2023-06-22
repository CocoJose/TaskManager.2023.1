using TaskManagerShared.Models;

namespace TaskManager.Fronend.Repositories
{
    public interface IRepository
    {
        Task<Response<T>> GetAsync<T>(string url);

    }
}
