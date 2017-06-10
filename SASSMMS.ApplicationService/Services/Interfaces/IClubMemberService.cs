using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IClubMemberService
    {
        bool InsertClubMember(ClubMember clubMember);
        void InsertClubMembers(List<ClubMember> lstClubMembers);
        void UpdateClubMembers(List<ClubMember> lstClubMembers);
        void UpdateClubMember(ClubMember clubMember);
        bool DeleteClubMember(ClubMember clubMember);
        List<ClubMember> GetAllClubMembers();


    }
}
