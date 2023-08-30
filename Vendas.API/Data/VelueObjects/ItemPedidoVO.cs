namespace Vendas.API.Data.VelueObjects
{
    public class ItemPedidoVO
    {
        public long Id { get; set; }
        public long Nome { get; set;}
        public long Prico { get; set;}
        public long Descricao { get; set;}
        public string? Categoiria { get; set;}
        public string? ImagemURL { get; set; }
    }
}
