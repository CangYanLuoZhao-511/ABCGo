using ABCGo.Core.ProjectAggregate;
using ABCGo.SharedKernel;

namespace ABCGo.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}