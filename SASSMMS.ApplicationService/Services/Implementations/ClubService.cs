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
    public class ClubService : IClubService
    {
        private UnitOfWork unitOfWork;
        public ClubService()
        {
            unitOfWork=new UnitOfWork();
            
        }
        public bool DeletClub(Club club)
        {
            unitOfWork.ClubRepository.Delete(club);
            return unitOfWork.Save();
        }

        public List<Club> GetAllClubs()
        {
            return unitOfWork.ClubRepository.GetAll().ToList();
        }

        public Club GetClub(Guid id)
        {
            return unitOfWork.ClubRepository.GetById(id);
        }

        public bool InsertClub(Club club)
        {
            unitOfWork.ClubRepository.Insert(club);
            return  unitOfWork.Save();
        }

        public bool UpdateClub(Club club)
        {
            unitOfWork.ClubRepository.Update(club);
            return unitOfWork.Save();
        }
    }
}
