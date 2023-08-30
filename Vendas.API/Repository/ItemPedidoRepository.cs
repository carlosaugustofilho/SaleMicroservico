using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vendas.API.Data.VelueObjects;
using Vendas.API.Model.Context;

namespace Vendas.API.Repository
{
    public class ItemPedidoRepository : IItemPedidoRepository
    {
        private readonly SQLContext _context;
        private readonly IMapper _mapper;

        public ItemPedidoRepository( SQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ItemPedidoVO>> FindAll()
        {
            List<ItemPedido> ItensPedido = await _context.ItensPedido.ToListAsync();
            return _mapper.Map<List<ItemPedidoVO>>(ItensPedido);
        }

        public async Task<ItemPedidoVO> FindById(long id)
        {
            ItemPedido product =
                 await _context.ItensPedido.Where(p => p.Id == id)
                 .FirstOrDefaultAsync();
            return _mapper.Map<ItemPedidoVO>(product);
        }

        public async Task<ItemPedidoVO> Create(ItemPedidoVO vo)
        {
            ItemPedido itempedido = _mapper.Map<ItemPedido>(vo);
            _context.ItensPedido.Add(itempedido);
            await _context.SaveChangesAsync();
            return _mapper.Map<ItemPedidoVO>(itempedido);
        }

        public async Task<ItemPedidoVO> Update(ItemPedidoVO vo)
        {
            ItemPedido ItemPedido = _mapper.Map<ItemPedido>(vo);
            _context.ItensPedido.Update(ItemPedido);
            await _context.SaveChangesAsync();
            return _mapper.Map<ItemPedidoVO>(ItemPedido);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                ItemPedido ItemPedido =
                await _context.ItensPedido.Where(p => p.Id == id)
                    .FirstOrDefaultAsync();
                if (ItemPedido == null) return false;
                _context.ItensPedido.Remove(ItemPedido);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

       
    }
}
