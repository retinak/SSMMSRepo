using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IMemberStatusService
    {
        bool InsertMemberStatus(MemberStatus memberStatus);
        bool UpdateMemberStatus(MemberStatus memberStatus);
        bool DeleteMemberStatus(MemberStatus memberStatus);
    }
}
