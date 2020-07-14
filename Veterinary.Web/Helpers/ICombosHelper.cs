using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Veterinary.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPetTypes();

        IEnumerable<SelectListItem> GetComboServiceTypes();
    }
}