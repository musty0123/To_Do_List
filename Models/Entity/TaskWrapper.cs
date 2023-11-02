using System.ComponentModel.DataAnnotations;

namespace To_Do_List.Models.Entity
{
    public class TaskWrapper
    {

        public int Id { get; set; }
        public string task { get; set; }

        public DateTime RecievedTime { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }


    }
}
