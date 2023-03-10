using System;
using CsvHelper.Configuration;

namespace BTB.Importer.Models
{
    public class LodgifyModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string SourceText { get; set; }
        public string Name { get; set; }
        public DateTime DateArrival { get; set; }
        public DateTime DateDeparture { get; set; }
        public int Nights { get; set; }
        public string HouseName { get; set; }
        public string InternalCode { get; set; }
        public int House_Id { get; set; }
        public string RoomTypes { get; set; }
        public int People { get; set; }
        public DateTime DateCreated { get; set; }
        public double TotalAmount { get; set; }
        public string Currency { get; set; }
        public string PromotionCode { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CountryName { get; set; }
        public string IPCreated { get; set; }
        public string IPCountry { get; set; }
        public int? QuoteId { get; set; }
        public string QuoteStatus { get; set; }
        public string RoomRatesTotal { get; set; }
        public int? PromotionsTotal { get; set; }
        public string FeesTotal { get; set; }
        public string TaxesTotal { get; set; }
        public int? AddOnsTotal { get; set; }
        public string AddOnsDetail { get; set; }
        public int AmountPaid { get; set; }
        public double BalanceDue { get; set; }
        public string ChangeRequestAdjustment { get; set; }
        public string PolicyName { get; set; }
        public string PaymentPolicy { get; set; }
        public string CancellationPolicy { get; set; }
        public string DamageDepositPolicy { get; set; }
        public string OwnerId { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public string OwnerEmail { get; set; }
        public int? OwnerPayout { get; set; }
        public int? IncludedVatTotal { get; set; }
        public string Notes { get; set; }
    }

    public class LodgifyModelMap : ClassMap<LodgifyModel>
    {
        public LodgifyModelMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Type).Name("Type");
            Map(m => m.Source).Name("Source");
            Map(m => m.SourceText).Name("SourceText");
            Map(m => m.Name).Name("Name");
            Map(m => m.DateArrival).Name("DateArrival");
            Map(m => m.DateDeparture).Name("DateDeparture");
            Map(m => m.Nights).Name("Nights");
            Map(m => m.HouseName).Name("HouseName");
            Map(m => m.InternalCode).Name("InternalCode");
            Map(m => m.House_Id).Name("House_Id");
            Map(m => m.RoomTypes).Name("RoomTypes");
            Map(m => m.People).Name("People");
            Map(m => m.DateCreated).Name("DateCreated");
            Map(m => m.TotalAmount).Name("TotalAmount");
            Map(m => m.Currency).Name("Currency");
            Map(m => m.PromotionCode).Name("PromotionCode");
            Map(m => m.Status).Name("Status");
            Map(m => m.Email).Name("Email");
            Map(m => m.Phone).Name("Phone");
            Map(m => m.CountryName).Name("CountryName");
            Map(m => m.IPCreated).Name("IPCreated");
            Map(m => m.IPCountry).Name("IPCountry");
            Map(m => m.QuoteId).Name("QuoteId");
            Map(m => m.QuoteStatus).Name("QuoteStatus");
            Map(m => m.RoomRatesTotal).Name("RoomRatesTotal");
            Map(m => m.PromotionsTotal).Name("PromotionsTotal");
            Map(m => m.FeesTotal).Name("FeesTotal");
            Map(m => m.TaxesTotal).Name("TaxesTotal");
            Map(m => m.AddOnsTotal).Name("AddOnsTotal");
            Map(m => m.AddOnsDetail).Name("AddOnsDetail");
            Map(m => m.AmountPaid).Name("AmountPaid");
            Map(m => m.BalanceDue).Name("BalanceDue");
            Map(m => m.ChangeRequestAdjustment).Name("ChangeRequestAdjustment");
            Map(m => m.PolicyName).Name("PolicyName");
            Map(m => m.PaymentPolicy).Name("PaymentPolicy");
            Map(m => m.CancellationPolicy).Name("CancellationPolicy");
            Map(m => m.DamageDepositPolicy).Name("DamageDepositPolicy");
            Map(m => m.OwnerId).Name("OwnerId");
            Map(m => m.OwnerFirstName).Name("OwnerFirstName");
            Map(m => m.OwnerLastName).Name("OwnerLastName");
            Map(m => m.OwnerEmail).Name("OwnerEmail");
            Map(m => m.OwnerPayout).Name("OwnerPayout");
            Map(m => m.IncludedVatTotal).Name("IncludedVatTotal");
            Map(m => m.Notes).Name("Notes");
        }
    }

}

