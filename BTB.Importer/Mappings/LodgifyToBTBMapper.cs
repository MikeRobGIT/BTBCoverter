using System;
using AutoMapper;
using BTB.Importer.Models;

namespace BTB.Importer.Mappings
{
	public class LodgifyToBTBMapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LodgifyModel, BTBModel>()
                // Required Fields
                .ForMember(dest => dest.LastName,               act => act.MapFrom(src => src.Name ))
                .ForMember(dest => dest.ResidentialCountry,     act => act.MapFrom(src => src.CountryName))
                .ForMember(dest => dest.GuestNationality,       act => act.MapFrom(src => src.CountryName))
                .ForMember(dest => dest.NumberOfAdults,         act => act.MapFrom(src => src.People))
                .ForMember(dest => dest.NightsOfStay,           act => act.MapFrom(src => src.Nights))
                .ForMember(dest => dest.CheckInDate,            act => act.MapFrom(src => src.DateArrival))
                .ForMember(dest => dest.CheckoutDate,           act => act.MapFrom(src => src.DateDeparture))
                .ForMember(dest => dest.AverageDailyRate,       act => act.MapFrom(src => decimal.TryParse(src.RoomRatesTotal, out var rate) ? rate : default(decimal)))
                .ForMember(dest => dest.AccommodationCharges,   act => act.MapFrom(src => src.TotalAmount))
                .ForMember(dest => dest.AccommodationTaxAmount, act => act.MapFrom(src => src.TaxesTotal))

                // Not Available
                .ForMember(dest => dest.CityTownVillage, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.StateProvinceDistrict, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.NoShow, act => act.MapFrom(src => "N"))
                .ForMember(dest => dest.TaxExempt, act => act.MapFrom(src => "N"))
                .ForMember(dest => dest.RentalSpaceType, act => act.MapFrom(src => "Unit"))
                .ForMember(dest => dest.NumberOfChildren, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.ComplimentaryStay, act => act.MapFrom(src => "N"))
                .ForMember(dest => dest.AccommodationTaxRate, act => act.MapFrom(src => 9))

                // Optional
                .ForMember(dest => dest.PhoneNumber,            act => act.MapFrom(src => src.Phone))
                .ForMember(dest => dest.EmailAddress,           act => act.MapFrom(src => src.Email))
                .ForMember(dest => dest.HotelInvoiceNumber,     act => act.MapFrom(src => $"Lodgify-{src.QuoteId}"))
                .ForMember(dest => dest.ReferenceNumber,        act => act.MapFrom(src => $"{src.Source}-{src.SourceText}"))
                .ForMember(dest => dest.RentalSpaceNumber,      act => act.MapFrom(src => src.HouseName.Replace("MeMe’s Place - ", "")))

                // Not Available
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.MiddleName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.ResidentialAddress, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.ZipCode, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DocumentType, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DocumentNumber, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DocumentIssueCountry, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DocumentExpirationDate, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Notes, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DiscountsOffered, act => act.MapFrom(src => ""))
                ;

                //Any Other Mapping Configuration ....
                cfg.CreateMap<BTBModel, LodgifyModel>()
                // Required Fields
                .ForMember(dest => dest.AddOnsDetail, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.AddOnsTotal, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.AmountPaid, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.BalanceDue, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.CancellationPolicy, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.ChangeRequestAdjustment, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.CountryName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Currency, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DamageDepositPolicy, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DateArrival, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DateCreated, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.DateDeparture, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Email, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.FeesTotal, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.HouseName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.House_Id, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Id, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.IncludedVatTotal, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.InternalCode, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.IPCountry, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.IPCreated, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Name, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Nights, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Notes, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.OwnerEmail, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.OwnerFirstName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.OwnerId, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.OwnerLastName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.OwnerPayout, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.PaymentPolicy, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.People, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Phone, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.PolicyName, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.PromotionCode, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.PromotionsTotal, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.QuoteId, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.QuoteStatus, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.RoomRatesTotal, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.RoomTypes, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Source, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.SourceText, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Status, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.TaxesTotal, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.TotalAmount, act => act.MapFrom(src => ""))
                .ForMember(dest => dest.Type, act => act.MapFrom(src => ""))
                ;
            });

            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}

