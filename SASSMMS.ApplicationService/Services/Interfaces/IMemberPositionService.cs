using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IMemberPositionService
    {
        bool InsertMemberPosition(MemberPosition memberPosition);
        bool UpdateMemberPosition(MemberPosition memberPosition);
        bool DeleteMemberPosition(MemberPosition memberPosition);
    }
}
