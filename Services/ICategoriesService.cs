using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameMVC.Services
{
    public interface ICategoriesService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
