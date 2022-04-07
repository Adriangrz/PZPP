using AutoMapper;
using EquipmentManagement.Models;

namespace EquipmentManagement.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<ProductCreateOrEditViewModel, Product>();
        }
    }
}
