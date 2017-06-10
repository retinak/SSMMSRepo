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
    public class MemberStatusService :IMemberStatusService
    {
        private UnitOfWork unitOfWork;
        public MemberStatusService()
        {
            unitOfWork=new UnitOfWork();
            
        }
        public bool InsertMemberStatus(MemberStatus memberStatus)
        {
            unitOfWork.MemberStatusRepository.Insert(memberStatus);
            return unitOfWork.Save();
        }

        public bool UpdateMemberStatus(MemberStatus memberStatus)
        {

            unitOfWork.MemberStatusRepository.Update(memberStatus);
            return unitOfWork.Save();
        }

        public bool DeleteMemberStatus(MemberStatus memberStatus)
        {

            unitOfWork.MemberStatusRepository.Delete(memberStatus);
            return unitOfWork.Save();
        }
    }
}
