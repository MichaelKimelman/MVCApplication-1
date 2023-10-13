using MVCApplication_1.Data;

namespace MVCApplication_1.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
    }
}
