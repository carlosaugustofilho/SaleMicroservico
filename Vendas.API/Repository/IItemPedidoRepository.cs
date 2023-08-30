using Vendas.API.Data.VelueObjects;

namespace Vendas.API.Repository
{
    public interface IItemPedidoRepository
    {
        Task<IEnumerable<ItemPedidoVO>> FindAll();
        Task<ItemPedidoVO> FindById(long id);
        Task<ItemPedidoVO> Create(ItemPedidoVO vo);
        Task<ItemPedidoVO> Update(ItemPedidoVO vo);
        Task<bool> Delete(long id);
    }
}
