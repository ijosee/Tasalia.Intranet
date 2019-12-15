using System;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class AppendantInfo
    {
        public int AppendantInfoId { get; set; }
        public Guid? ProcessGuid { get; set; }
        public int PropertyId { get; set; }
        public int AppraisalInfoId { get; set; }
        public int? AppendantTypeId { get; set; }
        public decimal? AdoptedArea { get; set; }
        public decimal? AreaRepercussionPrice { get; set; }
        public decimal? AppliedPercentage { get; set; }
        public bool? IsDuplex { get; set; }
        public bool? IsPenthhouse { get; set; }
        public string Estate { get; set; }
        public string Allocation { get; set; }
        public int? UseTypeId { get; set; }
        public string CatastralReference { get; set; }
        public int? EstateTypeId { get; set; }
        public int? UseStateId { get; set; }
        public decimal? MarketValue { get; set; }
        public decimal? EstateSurface { get; set; }
        public decimal? UsefullSurface { get; set; }
        public decimal? ZcvuiltSurface { get; set; }
        public decimal? BuiltPrivativeSurface { get; set; }
        public decimal? FreeHeight { get; set; }
        public decimal? FacadePr { get; set; }
        public decimal? FacadeSe { get; set; }
        public decimal? Depth { get; set; }
        public decimal? FreeLight { get; set; }
        public decimal? CurrentReplacementCost { get; set; }
        public decimal? FinalReplacementCost { get; set; }
        public string Name { get; set; }
        public int? HeatingTypeId { get; set; }
        public short? Bathrooms { get; set; }
        public short? Rooms { get; set; }
        public int? MakingQualityId { get; set; }
        public int? LocationQualityId { get; set; }
        public decimal? GroupValue { get; set; }
        public decimal? TechnicalEstimation { get; set; }
        public decimal? M2price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual AppendantType AppendantType { get; set; }
        public virtual EstateType EstateType { get; set; }
        public virtual HeatingType HeatingType { get; set; }
        public virtual LocationQuality LocationQuality { get; set; }
        public virtual MakingQuality MakingQuality { get; set; }
        public virtual Property Property { get; set; }
        public virtual UseState UseState { get; set; }
        public virtual UseType UseType { get; set; }
    }
}
