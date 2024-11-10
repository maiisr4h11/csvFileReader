using Microsoft.AspNetCore.Mvc;

namespace CSVFileReader.Models
{
    public class CsvData
    {
        public string Company { get; set; }
        public DateTime CeCreated { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Project { get; set; }
        public string QuoNumber { get; set; }
        public string QuoTitle { get; set; }
        public string ItemServiceCode { get; set; }
        public string ItemService { get; set; }
        public string Description { get; set; }
        public string SubBrandCode { get; set; }
        public string SubBrand { get; set; }
        public string AgentCode { get; set; }
        public string Agent { get; set; }
        public string CustomerCode { get; set; }
        public string Customer { get; set; }
        public DateTime DetailingSamplingDay { get; set; }
        public int Quantity { get; set; }
        public int TotalQuantity { get; set; }
        public decimal RateUnit { get; set; }
        public decimal Price { get; set; }
        public decimal SST { get; set; }
        public decimal Total { get; set; }
        public string TaxCode { get; set; }
    }

}
