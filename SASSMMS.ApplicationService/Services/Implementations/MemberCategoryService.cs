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
    public class MemberCategoryService :IMemberCategoryService
    {
        private readonly UnitOfWork unitOfWork;

        public MemberCategoryService()
        {
            unitOfWork = new UnitOfWork();
        }

        public bool InsertMemberCategory(MemberCategory memberCategory)
        {
            unitOfWork.MemberCategoryRepository.Insert(memberCategory);
            return unitOfWork.Save();
        }

        public bool UpdateMemberCategory(MemberCategory memberCategory)
        {
            unitOfWork.MemberCategoryRepository.Update(memberCategory);
            return unitOfWork.Save();
        }

        public bool DeleteMemberCategory(MemberCategory memberCategory)
        {
            unitOfWork.MemberCategoryRepository.Delete(memberCategory);
            return unitOfWork.Save();
        }
    }
}
