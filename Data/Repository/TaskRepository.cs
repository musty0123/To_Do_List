using To_Do_List.Models.Entity;

namespace To_Do_List.Data.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private ApplicationDbContext context;

        public TaskRepository(ApplicationDbContext context) => this.context = context;

        public IEnumerable<TaskWrapper> GetTasks()
        {
            return context.tasks.OrderBy(m => m.DueDate).ToList(); ;
        }
        public void AddTask(TaskWrapper item)
        {
            context.tasks.Add(item);
            
        }

        public void DeleteTask(int id)
        {
            var item = GetTaskByID(id);
            context.tasks.Remove(item);
        }

       

        public TaskWrapper GetTaskByID(int id) => context.tasks.Find(id);


        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateTask(TaskWrapper item)
        {
            context.tasks.Update(item);
        }
    }
}
