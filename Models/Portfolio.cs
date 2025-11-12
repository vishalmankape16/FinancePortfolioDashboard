using System;
using System.ComponentModel.DataAnnotations;

namespace FinancePortfolioDashboard.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Portfolio Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Initial Investment is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Investment must be a positive number")]
        public decimal InitialInvestment { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Risk Level is required")]
        public string RiskLevel { get; set; }
    }
}
