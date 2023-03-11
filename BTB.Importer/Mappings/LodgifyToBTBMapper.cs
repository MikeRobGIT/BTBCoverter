using System.Globalization;
using AutoMapper;
using BTB.Importer.Models;
using BTB.Importer.Extensions;
using CsvHelper;

namespace BTB.Importer.Mappings
{
    public class LodgifyToBTBMapperConfig
    {
        public List<BTBModel> Map(string sourceCsv)
        {
            using var reader = new StreamReader(sourceCsv);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<LodgifyModelMap>();

            var records = csv.GetRecords<LodgifyModel>().ToList();
            var mapper = InitializeAutomapper();

            return records.Select(item => mapper.Map<BTBModel>(item)).ToList();
        }

        private static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<LodgifyModel, BTBModel>()
                // Required Fields
                .ForMember(dest => dest.FirstName, act => act.MapFrom(src => src.Name.ToFirstName()))
                .ForMember(dest => dest.LastName, act => act.MapFrom(src => src.Name.ToLastName()))
                .ForMember(dest => dest.NumberOfAdults, act => act.MapFrom(src => src.People))
                .ForMember(dest => dest.NightsOfStay, act => act.MapFrom(src => src.Nights))
                .ForMember(dest => dest.CheckInDate, act => act.MapFrom(src => src.DateArrival.ToString("yyyy/MM/dd")))
                .ForMember(dest => dest.CheckoutDate, act => act.MapFrom(src => src.DateDeparture.ToString("yyyy/MM/dd")))

                .ForMember(dest => dest.AccommodationCharges, act => act.MapFrom(src =>
                    (src.RoomRatesTotal.ToDecimal() + src.TaxesTotal.ToDecimal()) * 2))
                .ForMember(dest => dest.AccommodationTaxAmount, act => act.MapFrom(src =>
                    src.TaxesTotal.ToDecimal() * 2))
               .ForMember(dest => dest.AverageDailyRate, act =>
                    act.MapFrom(src => ((src.RoomRatesTotal.ToDecimal() + src.TaxesTotal.ToDecimal()) / src.Nights) * 2))
               .ForMember(dest => dest.AccommodationTaxRate, act =>
                    act.MapFrom(src => 9))
                //.ForMember(dest => dest.GuestNationality, act => act.MapFrom(src => src.CountryName))
                //.ForMember(dest => dest.ResidentialCountry, act => act.MapFrom(src => src.CountryName))

                // Not Available
                //.ForMember(dest => dest.CityTownVillage, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.StateProvinceDistrict, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.RentalSpaceType, act => act.MapFrom(src => "Unit"))
                .ForMember(dest => dest.NoShow, act => act.MapFrom(src => "N"))
                .ForMember(dest => dest.TaxExempt, act => act.MapFrom(src => "N"))
                .ForMember(dest => dest.NumberOfChildren, act => act.MapFrom(src => 0))
                .ForMember(dest => dest.ComplimentaryStay, act => act.MapFrom(src => "N"))

                // Optional
                .ForMember(dest => dest.PhoneNumber, act => act.MapFrom(src => src.Phone))
                .ForMember(dest => dest.EmailAddress, act => act.MapFrom(src => src.Email))
                .ForMember(dest => dest.HotelInvoiceNumber, act => act.MapFrom(src => $"Lodgify-{src.QuoteId}"))
                .ForMember(dest => dest.ReferenceNumber, act => act.MapFrom(src => $"{src.Source}-{src.SourceText}"))
                .ForMember(dest => dest.RentalSpaceNumber, act => act.MapFrom(src =>
                    src.HouseName
                       .Replace("MeMe's Place - Villa ", "")
                       .Replace("MeMe's Place", "1&2")
                    ))

                // Not Available
                //.ForMember(dest => dest.MiddleName, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.ResidentialAddress, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.ZipCode, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.DocumentType, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.DocumentNumber, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.DocumentIssueCountry, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.DocumentExpirationDate, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.Notes, act => act.MapFrom(src => ""))
                //.ForMember(dest => dest.DiscountsOffered, act => act.MapFrom(src => ""))
                ;
            });

            //Create an Instance of Mapper and return that Instance
            var mapper = new Mapper(config);
            return mapper;
        }


    }
}

