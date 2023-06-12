using AutoMapper;

namespace AutoMapperCore.Models
{
    public class EmpProfile:Profile
    {
        public EmpProfile()
        {
            CreateMap<Employee, EmpVM>().ForMember(d => d.EmailConfirm, o => o.MapFrom(s => s.Email));

            CreateMap<EmpVM, Employee>();
        }
    }
}
