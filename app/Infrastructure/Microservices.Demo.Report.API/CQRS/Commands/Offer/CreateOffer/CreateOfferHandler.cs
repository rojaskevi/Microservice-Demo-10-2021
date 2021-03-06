namespace Microservices.Demo.Report.API.CQRS.Commands.Offer.CreateOffer
{
    using MediatR;
    using Microservices.Demo.Report.API.Domain;
    using Microservices.Demo.Report.API.Infrastructure.Agents.Pricing;
    using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
    using Microservices.Demo.Report.API.Infrastructure.Data.UnitOfWork;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    public class CreateOfferHandler : IRequestHandler<CreateOfferCommand, CreateOfferResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPricingAgent _pricingAgent;
        private readonly OfferDomainService _offerDomainService;

        public CreateOfferHandler(IUnitOfWork unitOfWork, IPricingAgent pricingAgent,OfferDomainService offerDomainService)
        {
            _unitOfWork = unitOfWork;
            _pricingAgent = pricingAgent;
            _offerDomainService = offerDomainService;
        }

        public async Task<CreateOfferResult> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
        {
            //calculate price
            var priceParams = ConstructPriceParams(request);
            var price = await _pricingAgent.CalculatePrice(priceParams);


            var offer = _offerDomainService.CreateOfferForPrice(
                priceParams.ProductCode,
                priceParams.PolicyFrom,
                priceParams.PolicyTo,
                null,
                price
                );

            //create and save offer
            await _unitOfWork.Offers.Add(offer);
            await _unitOfWork.CommitChanges();

            //return result
            return ConstructResult(offer);
        }

        private CreateOfferResult ConstructResult(Offer offer)
        {
            return new CreateOfferResult
            {
                OfferNumber = offer.Number,
                TotalPrice = offer.TotalPrice,
                CoversPrices = offer.OfferCovers.ToDictionary(c => c.Code, c => c.Price)
            };
        }

        private PricingParams ConstructPriceParams(CreateOfferCommand request)
        {
            return new PricingParams
            {
                ProductCode = request.ProductCode,
                PolicyFrom = request.PolicyFrom,
                PolicyTo = request.PolicyTo,
                SelectedCovers = request.SelectedCovers,
                Answers = request.Answers.Select(a => Answer.Create(a.QuestionType, a.QuestionCode, a.GetAnswer())).ToList()
            };
        }
    }
}
