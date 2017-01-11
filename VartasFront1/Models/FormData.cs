using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VartasFront1.Models
{
    // Stores the input data from the form
    public class FormData
    {
        [Key]
        public int FormDataId { get; set; }

        [Required(ErrorMessage = "You must fill in the name")]
        public string prNameData { get; set; }

        // not [Required] for testing purposes
        public string prEANData { get; set; }


        [Required(ErrorMessage = "You must fill in the product key")]
        public string prCodeData { get; set; }

        public string prManufacturerData { get; set; }
        public string prCategoryData { get; set; }

        [Required(ErrorMessage = "You must fill in the price")]
        public decimal prPriceData { get; set; }

        public bool prWarrantyData { get; set; }
        public int prWarMonthData { get; set; }
        public bool prIsStorageProductData { get; set; }
        public bool prSaldoPositiveData { get; set; }
        public int prSaldoData { get; set; }
    }

    public class FormDataDBContext : DbContext
    {
        public DbSet<FormData> Forms { get; set; }
    }
}