using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SASSMMS.ApplicationService.Services.Interfaces;
using SASSMMS.Domain.Entities;
using SASSMMS.Repository;

namespace SASSMMS.ApplicationService.Services.Implementations
{
    public class MemberAttendanceService : IMemberAttendanceService
    {

        private readonly UnitOfWork unitOfWork;

        public MemberAttendanceService()
        {
            unitOfWork=new UnitOfWork();
        }
        public bool InsertAttendance(Attendance attendance)
        {
           unitOfWork.AttendanceRepository.Insert(attendance);
            return unitOfWork.Save();
        }

        public bool UpdateAttendance(Attendance attendance)
        {
            unitOfWork.AttendanceRepository.Insert(attendance);
            return unitOfWork.Save();
        }

        public bool DeleteAttendance(Attendance attendance)
        {
            unitOfWork.AttendanceRepository.Delete(attendance);
            return unitOfWork.Save();
        }

        public List<Attendance> GetAttendances()
        {
            return unitOfWork.AttendanceRepository.GetAll().ToList();
        }

        public Attendance GetAttendance(Guid? id)
        {
            return unitOfWork.AttendanceRepository.GetById(id);
        }

        public IEnumerable<Attendance> Get(Expression<Func<Attendance, bool>> filter = null, Func<IQueryable<Attendance>, IOrderedQueryable<Attendance>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public List<Attendance> FindBy(Expression<Func<Attendance, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
