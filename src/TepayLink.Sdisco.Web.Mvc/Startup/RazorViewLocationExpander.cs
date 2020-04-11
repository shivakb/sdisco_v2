﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Razor;

namespace TepayLink.Sdisco.Web.Startup
{
    /// <summary>
    /// That class is generated so that new areas that use default layout can use default components.
    /// </summary>
    public class RazorViewLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context) { }

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var locations = viewLocations.ToList();

            //{0} is like "Components/{componentname}/{viewname}"
            locations.Add("~/Areas/Admin/Views/Shared/{0}.cshtml");

            return locations;
        }
    }
}
