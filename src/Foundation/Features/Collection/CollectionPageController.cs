﻿using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Foundation.Cms.ViewModels;
using Foundation.Commerce.Models.Pages;

namespace Foundation.Features.Collection
{
    public class CollectionPageController : PageController<CollectionPage>
    {
        public ActionResult Index(CollectionPage currentPage)
        {
            return View(ContentViewModel.Create(currentPage));
        }
    }
}