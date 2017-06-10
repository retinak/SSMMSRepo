using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IMemberCategoryService
    {
        bool InsertMemberCategory(MemberCategory memberCategory);
        bool UpdateMemberCategory(MemberCategory memberCategory);
        bool DeleteMemberCategory(MemberCategory memberCategory);
    }
}
