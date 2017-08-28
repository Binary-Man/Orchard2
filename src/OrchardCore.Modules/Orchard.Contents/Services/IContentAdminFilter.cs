using Orchard.ContentManagement;
using Orchard.Contents.ViewModels;
using Orchard.DisplayManagement.ModelBinding;
using Orchard.Navigation;
using System.Threading.Tasks;
using YesSql;

namespace Orchard.Contents.Services
{
    public interface IContentAdminFilter
    {
        Task FilterAsync(IQuery<ContentItem> query, ListContentsViewModel model, PagerParameters pagerParameters, IUpdateModel updateModel);
    }

    public interface IContentApiFilter
    {
        Task FilterAsync(IQuery<ContentItem> query, string parentContentItemId);
    }
}
