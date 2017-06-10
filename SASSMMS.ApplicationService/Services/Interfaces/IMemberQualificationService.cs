using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IMemberQualificationService
    {
        bool InsertMemberQualification(MemberQualification memberQualification);
        bool UpdateMemberQualification(MemberQualification memberQualification);
        bool DeleteMemberQualification(MemberQualification memberQualification);
    }
}
