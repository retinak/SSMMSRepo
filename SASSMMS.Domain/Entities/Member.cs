using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SASSMMS.Domain.Entities
{
    public class Member :Person
    {

        public Member()
        {
           var occupations=new List<Occupation>();
        }
        public Guid MemberId  { get; set; }
        public Guid? ClubId { get; set; }
        public string AttendanceNmumber { get; set; }

        //public  Guid SubDivisionId { get; set; }
        public Guid ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public string CurrentStatus { get; set; }
        public string Company { get; set; }
        public Guid SchoolId { get; set; }


        #region Navigation 
        public virtual School School { get; set; }
        public  virtual  Club Club { get; set;  }
        public virtual List<MemberQualification> MemberQualifications { get; set; }
        public virtual List<MemberPosition> MemberPositions { get; set; }
    
        public Guid DivisionId { get; set; }
        public  virtual  Division Division { get; set; }
       
        public List<MemberOccupation> MemberOccupations { get; set; } 
       
        public virtual ICollection<MemberCategory> MemberCategories { get; set; }

        public virtual List<MemberStatus> MemberStatuses { get; set; }

        public virtual List<Address> Addresses { get; set; }
        //public virtual List<Division> Divisions { get; set; }// can a member be in Division and at the same time in sub division?
        #endregion
        public virtual List<TemporaryMember> TemporaryMembers { get; set; }
        public virtual List<TemporaryClassA> TemporaryClassAs { get; set; }
        public virtual List<PermanetMember> PermanetMembers { get; set; }
        public override string FirstName { get; set; }
        public override string FatherName { get; set; }
        public override string GrandfatherName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public override DateTime DateOfBirth { get; set; }
        public override string Gender { get; set; }
        
    }
}
