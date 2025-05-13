using AutoMapper;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private static List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Item1", Description = "This is Item 1" },
            new Item { Id = 2, Name = "Item2", Description = "This is Item 2" }
        };
        private readonly IMapper _mapper;
        
        public ItemController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ItemDTO>> GetAll()
        {
            // Map the list of Items to a list of ItemDTOs
            var itemsDTO = _mapper.Map<List<ItemDTO>>(_items);
            return Ok(itemsDTO);
        }
        [HttpGet("{id}")]
        public ActionResult<ItemDTO> GetById(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound($"Item with ID {id} not found.");
            }

            // Map the Item to an ItemDTO
            var itemDTO = _mapper.Map<ItemDTO>(item);
            return Ok(itemDTO);
        }
        [HttpPost]
        public ActionResult<ItemDTO> Create(ItemDTO newItemDTO)
        {
            if (_items.Any(i => i.Id == newItemDTO.Id))
            {
                return BadRequest($"Item with ID {newItemDTO.Id} already exists.");
            }

            // Map the ItemDTO to an Item
            var newItem = _mapper.Map<Item>(newItemDTO);
            _items.Add(newItem);

            return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, newItemDTO);
        }
        [HttpPut("{id}")]
        public ActionResult<ItemDTO> Update(int id, ItemDTO updatedItemDTO)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound($"Item with ID {id} not found.");
            }

            // Update the item using AutoMapper
            _mapper.Map(updatedItemDTO, item);

            return Ok(updatedItemDTO);
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null)
            {
                return NotFound($"Item with ID {id} not found.");
            }

            _items.Remove(item);
            return NoContent();
        }
    }
}
