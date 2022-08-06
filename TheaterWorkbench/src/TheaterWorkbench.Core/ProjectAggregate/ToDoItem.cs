using TheaterWorkbench.Core.ProjectAggregate.Events;
using TheaterWorkbench.SharedKernel;

namespace TheaterWorkbench.Core.ProjectAggregate
{
    public class ToDoItem : EntityBase
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsDone { get; private set; }

        public void MarkComplete()
        {
            if (!IsDone)
            {
                IsDone = true;

                RegisterDomainEvent(new ToDoItemCompletedEvent(this));
            }
        }

        public override string ToString()
        {
            string status = IsDone ? "Done!" : "Not done.";
            return $"{Id}: Status: {status} - {Title} - {Description}";
        }
    }
}