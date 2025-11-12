using System;

namespace FinancePortfolioDashboard.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public required string Asset { get; set; }
        public required string Type { get; set; } // e.g., Buy/Sell
        public decimal Amount { get; set; } = 0m;
        public DateTime Date { get; set; } = DateTime.Now;

        // Optional: link to Portfolio or Asset if needed
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; } = null!;
    }
}
