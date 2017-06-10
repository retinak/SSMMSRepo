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
    public class MemberPositionService :IMemberPositionService
    {
        private UnitOfWork unitOfWork;

        public MemberPositionService()
        {
            unitOfWork=new UnitOfWork();
        }
        public bool InsertMemberPosition(MemberPosition memberPosition)
        {
            unitOfWork.MemberPositionRepository.Insert(memberPosition);
            return unitOfWork.Save();
        }

        public bool UpdateMemberPosition(MemberPosition memberPosition)
        {
            unitOfWork.MemberPositionRepository.Update(memberPosition);
            return unitOfWork.Save();
        }

        public bool DeleteMemberPosition(MemberPosition memberPosition)
        {
            unitOfWork.MemberPositionRepository.Delete(memberPosition);
            return unitOfWork.Save();
        }
    }
}
