using System.ComponentModel.DataAnnotations;

namespace TaskManagerShared.Entities
{
    public class MyTask
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; } = null!;

        public DateTime Date { get; set; }

        public bool IsCompleted { get; set; }

    }
}
