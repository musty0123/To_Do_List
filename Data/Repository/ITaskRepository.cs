using To_Do_List.Models.Entity;

namespace To_Do_List.Data.Repository
{
    public interface ITaskRepository
    {
        IEnumerable<TaskWrapper> GetTasks();
        TaskWrapper GetTaskByID(int studentId);
        void AddTask(TaskWrapper item);
        void DeleteTask(int id);
        void UpdateTask(TaskWrapper item);
        void Save();
    }
}
