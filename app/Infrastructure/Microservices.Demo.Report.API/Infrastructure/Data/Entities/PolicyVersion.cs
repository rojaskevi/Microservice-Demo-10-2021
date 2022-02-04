﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class PolicyVersion
    {
        public PolicyVersion()
        {
            PolicyCovers = new HashSet<PolicyCover>();
        }

        public int PolicyVersionId { get; set; }
        public int VersionNumber { get; set; }
        public decimal TotalPremiumAmount { get; set; }
        public int PolicyId { get; set; }
        public int PolicyHolderId { get; set; }
        public int CoverPeriodPolicyValidityPeriodId { get; set; }
        public int VersionValidityPeriodPolicyValidityPeriodId { get; set; }

        public virtual PolicyValidityPeriod CoverPeriodPolicyValidityPeriod { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual PolicyHolder PolicyHolder { get; set; }
        public virtual PolicyValidityPeriod VersionValidityPeriodPolicyValidityPeriod { get; set; }
        public virtual ICollection<PolicyCover> PolicyCovers { get; set; }
    }
}