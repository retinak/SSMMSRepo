using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
    public interface IMemberOccupationService
    {

        bool InsertMemberOccupation(MemberOccupation memberOccupation);
        bool UpdateMemberOccupation(MemberOccupation memberOccupation);
        bool DeleteMemberOccupation(MemberOccupation memberOccupation);
        List<MemberOccupation> GetMemberOccupations();
        //Member GetMember(Guid? id);
        //IEnumerable<Member> Get(
        // Expression<Func<Member, bool>> filter = null,
        // Func<IQueryable<Member>, IOrderedQueryable<Member>> orderBy = null,
        // string includeProperties = "");
        //List<Member> FindBy(Expression<Func<Member, bool>> predicate);
    }
}
