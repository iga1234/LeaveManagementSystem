using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class LeaveTypeAutoMapperProfile : Profile
    {
        public LeaveTypeAutoMapperProfile() {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            //When in IndexVM variable name is Days and in LeaveType is NumberOfDays 
            //.ForMember(dest => dest.NumberOfDays, opt => opt.MapFrom(src => src.NumberOfDays));
            CreateMap<LeaveTypeCreateVM, LeaveType>();
            CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
        }

    }
}
