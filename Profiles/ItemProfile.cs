using AutoMapper;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;

namespace AutoMapperExample.Profiles
{
    public class ItemProfile:Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemDTO>();
            CreateMap<ItemDTO, Item>();
        }
    }
}
