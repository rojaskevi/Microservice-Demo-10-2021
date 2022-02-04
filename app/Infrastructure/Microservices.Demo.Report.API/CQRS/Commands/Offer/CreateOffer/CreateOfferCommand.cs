using MediatR;
using Microservices.Demo.Report.API.CQRS.Commands.Infrastructure.Dtos.Offer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Commands.Offer.CreateOffer
{
    public class CreateOfferCommand : IRequest<CreateOfferResult>
    {
        public string ProductCode { get; set; }
        public DateTime PolicyFrom { get; set; }
        public DateTime PolicyTo { get; set; }
        public List<string> SelectedCovers { get; set; }
        public List<QuestionAnswerDto> Answers { get; set; }
    }
}
