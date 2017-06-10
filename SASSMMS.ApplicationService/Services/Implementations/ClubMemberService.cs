using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.ApplicationService.Services.Interfaces;
using SASSMMS.Domain.Entities;
using SASSMMS.Repository;

namespace SASSMMS.ApplicationService.Services.Implementations
{
    public class ClubMemberService:IClubMemberService
    {
        private UnitOfWork unitOfWork;

        public ClubMemberService()
        {
            unitOfWork=new UnitOfWork();
        }
        public bool InsertClubMember(ClubMember clubMember)
        {
            unitOfWork.ClubMemberRepository.Insert(clubMember);
            return unitOfWork.Save();
        }

        public void InsertClubMembers(List<ClubMember> lstClubMembers)
        {
            unitOfWork.ClubMemberRepository.Insert(lstClubMembers);
            
        }

        public void UpdateClubMembers(List<ClubMember> lstClubMembers)
        {
            unitOfWork.ClubMemberRepository.Update(lstClubMembers);
        }

        public void UpdateClubMember(ClubMember clubMember)
        {
           unitOfWork.ClubMemberRepository.Update(clubMember);
        }

        public bool DeleteClubMember(ClubMember clubMember)
        {
            throw new NotImplementedException();
        }

        public List<ClubMember> GetAllClubMembers()
        {
            return unitOfWork.ClubMemberRepository.GetAll().ToList();
        }
    }
}
