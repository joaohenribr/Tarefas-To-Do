using System;
using System.ComponentModel.DataAnnotations.Schema;
using TarefasToDo.Enums;

namespace TarefasToDo.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public StatusTarefa IsCompleted { get; set; }
        public string? Category { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }

    }
}