namespace TarefasToDo.Models
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}