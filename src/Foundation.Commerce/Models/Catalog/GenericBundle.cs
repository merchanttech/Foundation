﻿using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace Foundation.Commerce.Models.Catalog
{
    [CatalogContentType(
        GUID = "F403ABFF-6C95-4B5B-AB7D-C15AE6055537",
        DisplayName = "Fashion Bundle",
        MetaClassName = "FashionBundle",
        Description = "Displays a bundle, which is collection of individual fashion variants.")]
    [ImageUrl("~/content/icons/pages/cms-icon-page-21.png")]
    public class GenericBundle : BundleContent, IProductRecommendations
    {
        [Searchable]
        [CultureSpecific]
        [Tokenize]
        [IncludeInDefaultSearch]
        [Display(Name = "Description", Order = 5)]
        public virtual XhtmlString Description { get; set; }

        [Searchable]
        [CultureSpecific]
        [Tokenize]
        [IncludeInDefaultSearch]
        [Display(Name = "Long description", Order = 10)]
        public virtual XhtmlString LongDescription { get; set; }

        [Display(Name = "On sale", Description = "Is on sale?", Order = 15)]
        public virtual bool OnSale { get; set; }

        [Display(Name = "New arrival", Description = "Is on a new arrival?", Order = 20)]
        public virtual bool NewArrival { get; set; }

        [CultureSpecific]
        [Display(Name = "Content area", Description = "This will display the content area.", Order = 25)]
        public virtual ContentArea ContentArea { get; set; }

        [CultureSpecific]
        [Display(Name = "Associations title",
            Description = "This is title of the Associations tab.",
            Order = 30)]
        public virtual string AssociationsTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Show recommendations", Description = "This will determine whether or not to show recommendations.", Order = 35)]
        public virtual bool ShowRecommendations { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            ShowRecommendations = true;
            AssociationsTitle = "You May Also Like";
        }
    }
}
