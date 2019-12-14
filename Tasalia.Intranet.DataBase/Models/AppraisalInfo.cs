using System;
using System.Collections.Generic;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class AppraisalInfo
    {
        public AppraisalInfo()
        {
            ConditioningAppraisal = new HashSet<ConditioningAppraisal>();
            MaterialAppraisal = new HashSet<MaterialAppraisal>();
            PropertyInfo = new HashSet<PropertyInfo>();
            WarningAppraisal = new HashSet<WarningAppraisal>();
        }

        public int AppraisalInfoId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public int AppraisalId { get; set; }
        public string Version { get; set; }
        public DateTime AppraisalDate { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public int Trimester { get; set; }
        public DateTime? VisitedDate { get; set; }
        public int? EntityId { get; set; }
        public int? EntityBranchId { get; set; }
        public string Petitioner { get; set; }
        public string PetitionerId { get; set; }
        public int? GoalId { get; set; }
        public int? RegistryId { get; set; }
        public int? AppraiserId { get; set; }
        public string CurrentReform { get; set; }
        public string CurrentState { get; set; }
        public bool? HasParking { get; set; }
        public decimal? ChargeAmount { get; set; }
        public string Lifts { get; set; }
        public bool? HasLift { get; set; }
        public bool? IsVpo { get; set; }
        public decimal? VpoValue { get; set; }
        public decimal? AppraisalValue { get; set; }
        public decimal? SureValue { get; set; }
        public int? StayTypeId { get; set; }
        public bool? HasPool { get; set; }
        public bool? IsBusy { get; set; }
        public int? VisitedId { get; set; }
        public int? OccupantTypeId { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual Appraisal Appraisal { get; set; }
        public virtual Appraiser Appraiser { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Goal Goal { get; set; }
        public virtual OccupantType OccupantType { get; set; }
        public virtual Registry Registry { get; set; }
        public virtual StayType StayType { get; set; }
        public virtual Visited Visited { get; set; }
        public virtual ICollection<ConditioningAppraisal> ConditioningAppraisal { get; set; }
        public virtual ICollection<MaterialAppraisal> MaterialAppraisal { get; set; }
        public virtual ICollection<PropertyInfo> PropertyInfo { get; set; }
        public virtual ICollection<WarningAppraisal> WarningAppraisal { get; set; }
    }
}
