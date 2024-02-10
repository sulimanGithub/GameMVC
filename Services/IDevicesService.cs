using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameMVC.Services
{
    public interface IDevicesService
    {
        IEnumerable<SelectListItem> GetSelectList();
    }
}
