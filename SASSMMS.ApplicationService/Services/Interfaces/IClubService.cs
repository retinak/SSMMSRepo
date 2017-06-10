using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.Domain.Entities;

namespace SASSMMS.ApplicationService.Services.Interfaces
{
   public interface IClubService
   {
       bool InsertClub(Club club);
       bool UpdateClub(Club club);
       bool DeletClub(Club club);
       List<Club> GetAllClubs();
       Club GetClub(Guid id);
   }
}
