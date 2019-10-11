using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Foundation.Cms.Pages
{
    [ContentType(DisplayName = "Folder Page",
        GUID = "1bc8e78b-40cc-4efc-a561-a0bba89b51ac",
        Description = "A page which allows you to structure pages.",
        GroupName = SystemTabNames.Content)]
    [AvailableContentTypes(IncludeOn = new[] { typeof(CmsHomePage), typeof(FolderPage) })]
    [ImageUrl("~/assets/icons/cms/pages/container.png")]
    public class FolderPage : FoundationPageData
    {
    }
}