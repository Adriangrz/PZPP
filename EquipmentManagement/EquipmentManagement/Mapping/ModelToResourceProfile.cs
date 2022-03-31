using AutoMapper;
using EquipmentManagement.Models;

namespace EquipmentManagement.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
