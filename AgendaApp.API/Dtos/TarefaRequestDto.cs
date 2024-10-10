using System.ComponentModel.DataAnnotations;

namespace AgendaApp.API.Dtos
{
    /// <summary>
    /// Modelo de dados para cadastro / edição de tarefa
    /// </summary>
    public class TarefaRequestDto
    {
        [Required(ErrorMessage = "Por favor, informe o nome da tarefa.")]
        [MinLength(6, ErrorMessage = "Informe o nome da tarefa com pelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe o nome da tarefa com máximo de {1} caracteres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da tarefa.")]
        [RegularExpression(@"\d{4}-\d{2}-\d{2}",
             ErrorMessage ="Informe a data da tarefa no formato 'YYYY-MM-DD'.")]
        public string? Data { get; set; }

        [Required(ErrorMessage = "Por favor, informe a hora da tarefa.")]
        [RegularExpression(@"\d{2}:\d{2}",
             ErrorMessage = "Informe a hora da tarefa no formato 'HH:MM'.")]
        public string? Hora { get; set; }

        [Required(ErrorMessage = "Por favor, informe a prioridade da tarefa.")]
        [Range(1, 3, ErrorMessage = "Por favor, informe a prioridade com valores 1, 2 ou 3.")]
        public int? Prioridade { get; set; }

        [Required(ErrorMessage = "Por favor, informe a categoria da tarefa.")]
        public Guid? CategoriaId { get; set; }
    }
}