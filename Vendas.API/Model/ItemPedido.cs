using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vendas.API.Model.Base;

public class ItemPedido : BaseEntity
{
    public long Id { get; set; }

    [Column("Nome")]
    [Required(ErrorMessage = "O nome do item é obrigatório.")]
    [StringLength(150)]
    public string? Nome { get; set; }


    [Column("price")]
    [Required]
    [Range(1, 10000)]
    public decimal ValorUnitario { get; set; }

    //[Column("image_url")]
    //[StringLength(300)]
    //public int PedidoId { get; set; }
    //public Pedido? Pedido { get; set; }
}
