﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Microservices.Demo.Report.API.Infrastructure.Data.Entities
{
    public partial class Offer
    {
        public Offer()
        {
            OfferCovers = new HashSet<OfferCover>();
        }

        public int OfferId { get; set; }
        public string Number { get; set; }
        public string ProductCode { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreationDate { get; set; }
        public string AgentLogin { get; set; }
        public int PolicyValidityPeriodId { get; set; }
        public int? PolicyHolderId { get; set; }
        public int OfferStatusId { get; set; }

        public virtual OfferStatus OfferStatus { get; set; }
        public virtual PolicyHolder PolicyHolder { get; set; }
        public virtual PolicyValidityPeriod PolicyValidityPeriod { get; set; }
        public virtual ICollection<OfferCover> OfferCovers { get; set; }
    }
}