using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public enum TaskStatus
    {
        Ready = 0,
        InProgress = 1,
        Done = 2,
        Canceled= 3
    }
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Employee Assignee { get; set; }
        public Project Project { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }
        
    }
}
