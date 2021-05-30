using ABCGo.Core.ProjectAggregate;
using Ardalis.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ABCGo.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}
