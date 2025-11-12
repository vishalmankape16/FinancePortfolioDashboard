using System;

namespace FinancePortfolioDashboard.Models
{
    public class Asset
    {
        public int Id { get; set; }

        public required string Symbol { get; set; }
        public required string AssetType { get; set; }
        public decimal Value { get; set; } = 0m;

        // New properties to match views
        public int Quantity { get; set; } = 0;
        public decimal CurrentPrice { get; set; } = 0m;

        // Foreign key to Portfolio
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; } = null!;
    }
}
