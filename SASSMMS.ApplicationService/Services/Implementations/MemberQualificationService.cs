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
    public class MemberQualificationService: IMemberQualificationService
    {
        private UnitOfWork unitOfWork;

        public MemberQualificationService()
        {
            unitOfWork=new UnitOfWork();
        }
        public bool InsertMemberQualification(MemberQualification memberQualification)
        {
            unitOfWork.MemberQualificationRepository.Insert(memberQualification);
            return unitOfWork.Save();
        }

        public bool UpdateMemberQualification(MemberQualification memberQualification)
        {
            unitOfWork.MemberQualificationRepository.Update(memberQualification);
            return unitOfWork.Save();
        }

        public bool DeleteMemberQualification(MemberQualification memberQualification)
        {
            unitOfWork.MemberQualificationRepository.Delete(memberQualification);
            return unitOfWork.Save();
        }
    }
}
