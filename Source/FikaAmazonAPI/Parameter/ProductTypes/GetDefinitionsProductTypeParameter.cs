﻿using FikaAmazonAPI.AmazonSpApiSDK.Models.ProductTypes;
using FikaAmazonAPI.Search;
using System.Collections.Generic;
using FikaAmazonAPI.Parameter.ListingItem;

namespace FikaAmazonAPI.Parameter.ProductTypes
{
    public class GetDefinitionsProductTypeParameter : ParameterBased
    {
        [PathParameter]
        public string productType { get; set; }
        public string sellerId { get; set; }
        public ICollection<string> marketplaceIds { get; set; } = new List<string>();
        public string productTypeVersion { get; set; }
        public Requirements? requirements { get; set; }
        public RequirementsEnforcedEnum? requirementsEnforced { get; set; }
        public LocaleEnum? locale { get; set; }

    }
}
