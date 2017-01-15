using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VartasBackend1.Models
{
    public class Tuote
    {
        [Key]
        [Display(Name = "Product Number")]
        public int TuoteId { get; set; }

        [Required(ErrorMessage = "You must fill in the name.")]
        [Display(Name = "Product name")]
        public string Name { get; set; }

        [Display(Name = "Manufacturer's Product Key")]
        public string ProductKey { get; set; }

        [Display(Name = "Manufacturer")]
        public string Manufacturer { get; set; }

        [Display(Name = "Category")]
        public string Category { get; set; }

        [Display(Name = "Price", Prompt = "0.00")]
        public decimal Price { get; set; }

        [Display(Name = "Storage product")]
        public bool IsStorageProduct { get; set; }

        [Display(Name = "In Stock")]
        public bool IsPrSaldoPositive { get; set; }

        [Display(Name = "Saldo")]
        public int Saldo { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Last edited")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Edited { get; set; }

        [Display(Name = "by")]
        public string Editor { get; set; }
    }

    // Luo tietokannan 'Tuotteet'
    public class TuoteDBContext : DbContext
    {
        public DbSet<Tuote> Tuotteet { get; set; }
    }

}