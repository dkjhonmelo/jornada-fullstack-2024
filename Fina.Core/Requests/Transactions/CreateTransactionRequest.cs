using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions;

public class CreateTransactionRequest : Request
{
    [Required(ErrorMessage = "Título Inválido")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Tipo Inválido")]
    public ETransactionType Type { get; set; } = ETransactionType.WithDraw;
    
    [Required(ErrorMessage = "Valor Inválido")]
    public decimal Amount { get; set; }
    
    [Required(ErrorMessage = "Categoria Inválido")]
    public long CategoryId { get; set; }
    
    [Required(ErrorMessage = "Data Inválida")]
    public DateTime? PaidOrReceivedAt { get; set; }
}