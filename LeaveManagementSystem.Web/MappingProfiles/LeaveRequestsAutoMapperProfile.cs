using AutoMapper;
using LeaveManagementSystem.Web.Models.LeaveRequests;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class LeaveRequestsAutoMapperProfile : Profile
    {
        public LeaveRequestsAutoMapperProfile()
        {
            CreateMap<LeaveRequestCreateVM, LeaveRequest>();
        }

    }
}
