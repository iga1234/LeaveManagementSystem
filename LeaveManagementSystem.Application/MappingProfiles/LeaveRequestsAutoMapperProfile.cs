using AutoMapper;

namespace LeaveManagementSystem.Application.MappingProfiles
{
    public class LeaveRequestsAutoMapperProfile : Profile
    {
        public LeaveRequestsAutoMapperProfile()
        {
            CreateMap<LeaveRequestCreateVM, LeaveRequest>();
        }

    }
}
