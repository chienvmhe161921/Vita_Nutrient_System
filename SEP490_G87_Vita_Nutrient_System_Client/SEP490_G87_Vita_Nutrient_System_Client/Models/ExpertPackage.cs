﻿namespace SEP490_G87_Vita_Nutrient_System_Client.Models
{
    public partial class ExpertPackage
    {
        public short? Id { get; set; }

        public int NutritionistDetailsId { get; set; }

        public string? Name { get; set; }

        public string? Describe { get; set; }

        public decimal? Price { get; set; }

        public short? Duration { get; set; }
    }
}