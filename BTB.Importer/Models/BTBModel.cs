using CsvHelper.Configuration;

namespace BTB.Importer.Models
{
    public class BTBModel
    {
        public BTBModel()
        {
            var locServ = new LocationService();
            var (city, state, country) = locServ.GetRandomLocation();
            CityTownVillage = city;
            StateProvinceDistrict = state;
            ResidentialCountry = country;
            GuestNationality = country;
        }

        public string ControlID { get; set; } = "HOT08748";
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string GuestNationality { get; set; }
        public string ResidentialAddress { get; set; }
        public string CityTownVillage { get; set; }
        public string StateProvinceDistrict { get; set; }
        public string ZipCode { get; set; }
        public string ResidentialCountry { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentIssueCountry { get; set; }
        public string DocumentExpirationDate { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; } = 0;
        public string RentalSpaceNumber { get; set; }
        public int NightsOfStay { get; set; }
        public string CheckInDate { get; set; }
        public string CheckoutDate { get; set; }
        public string HotelInvoiceNumber { get; set; }
        public string ReferenceNumber { get; set; }
        public string TaxExempt { get; set; }
        public string ComplimentaryStay { get; set; }
        public string AverageDailyRate { get; set; }
        public string AccommodationCharges { get; set; }
        public string AccommodationTaxRate { get; set; }
        public string AccommodationTaxAmount { get; set; }
        public string Notes { get; set; }
        public string NoShow { get; set; }
        public string DiscountsOffered { get; set; }
        public string RentalSpaceType { get; set; } = "Unit";
    }

    public class BTBModelMap : ClassMap<BTBModel>
    {
        public BTBModelMap()
        {
            Map(m => m.ControlID).Name("ControlID");
            Map(m => m.LastName).Name("LastName");
            Map(m => m.FirstName).Name("FirstName");
            Map(m => m.MiddleName).Name("MiddleName");
            Map(m => m.GuestNationality).Name("GuestNationality");
            Map(m => m.ResidentialAddress).Name("ResidentialAddress");
            Map(m => m.CityTownVillage).Name("CityTownVillage");
            Map(m => m.StateProvinceDistrict).Name("StateProvinceDistrict");
            Map(m => m.ZipCode).Name("ZipCode");
            Map(m => m.ResidentialCountry).Name("ResidentialCountry");
            Map(m => m.PhoneNumber).Name("PhoneNumber");
            Map(m => m.EmailAddress).Name("EmailAddress");
            Map(m => m.DocumentType).Name("DocumentType");
            Map(m => m.DocumentNumber).Name("DocumentNumber");
            Map(m => m.DocumentIssueCountry).Name("DocumentIssueCountry");
            Map(m => m.DocumentExpirationDate).Name("DocumentExpirationDate");
            Map(m => m.NumberOfAdults).Name("NumberOfAdults");
            Map(m => m.NumberOfChildren).Name("NumberOfChildren");
            Map(m => m.RentalSpaceNumber).Name("RentalSpaceNumber");
            Map(m => m.NightsOfStay).Name("NightsOfStay");
            Map(m => m.CheckInDate).Name("CheckInDate");
            Map(m => m.CheckoutDate).Name("CheckoutDate");
            Map(m => m.HotelInvoiceNumber).Name("HotelInvoiceNumber");
            Map(m => m.ReferenceNumber).Name("ReferenceNumber");
            Map(m => m.TaxExempt).Name("TaxExempt");
            Map(m => m.ComplimentaryStay).Name("ComplimentaryStay");
            Map(m => m.AverageDailyRate).Name("AverageDailyRate");
            Map(m => m.AccommodationCharges).Name("AccommodationCharges");
            Map(m => m.AccommodationTaxRate).Name("AccommodationTaxRate");
            Map(m => m.AccommodationTaxAmount).Name("AccommodationTaxAmount");
            Map(m => m.Notes).Name("Notes");
            Map(m => m.NoShow).Name("NoShow");
            Map(m => m.DiscountsOffered).Name("DiscountsOffered");
            Map(m => m.RentalSpaceType).Name("RentalSpaceType");
        }
    }

}

