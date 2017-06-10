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
    public class MemberOccupationService:IMemberOccupationService
    {
        private UnitOfWork unitOfWork;

        public MemberOccupationService()
        {
            unitOfWork=new UnitOfWork();
        }
        public bool InsertMemberOccupation(MemberOccupation memberOccupation)
        {
            unitOfWork.MemberOccupationsRepository.Insert(memberOccupation);
            return  unitOfWork.Save();
        }

        public bool UpdateMemberOccupation(MemberOccupation memberOccupation)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMemberOccupation(MemberOccupation memberOccupation)
        {
            throw new NotImplementedException();
        }

        public List<MemberOccupation> GetMemberOccupations()
        {
            throw new NotImplementedException();
        }
    }
}
