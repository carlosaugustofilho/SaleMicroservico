using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Vendas.API.Data.VelueObjects;
using Vendas.API.Repository;

namespace Vendas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidoController : ControllerBase
    {
        private IItemPedidoRepository _repository;

        public ItemPedidoController(IItemPedidoRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemPedidoVO>>> FindAll()
        {
            var itensPedido = await _repository.FindAll();
            return Ok(itensPedido);
        }

        [HttpGet("{id}")]
        //[Authorize]
        public async Task<ActionResult<ItemPedido>> FindById(int id)
        {
            var itemPedido = await _repository.FindById(id);
            if (itemPedido == null) return NotFound();
            return Ok(itemPedido);
        }

        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<ItemPedido>> Create([FromBody] ItemPedidoVO vo)
        {
            if (vo == null) return BadRequest();
            var ItemPedido = await _repository.Create(vo);
            return Ok(ItemPedido);
        }

        [HttpPut]
        //[Authorize]
        public async Task<ActionResult<ItemPedido>> Update([FromBody] ItemPedidoVO vo)
        {
            if (vo == null) return BadRequest();
            var updatedItemPedido = await _repository.Update(vo);
            return Ok(updatedItemPedido); 
        }

        [HttpDelete("{id}")]
        //[Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }
    }

}
