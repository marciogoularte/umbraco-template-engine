﻿namespace Zone.UmbracoTemplateEngine.Website.Controllers.WebPages
{
    using System.Linq;
    using System.Web.Mvc;
    using Zone.UmbracoTemplateEngine.Website.ContentTypes.Content;
    using Zone.UmbracoTemplateEngine.Website.Controllers.Base;
    using Zone.UmbracoTemplateEngine.Website.Services;

    public class ListController : BaseWebPageSurfaceController<List>
    {
        #region Constructor

        public ListController(ServiceCollection services)
            : base(services)
        {
        }

        #endregion

        #region Action methods

        public ActionResult List()
        {
            var model = GetModel();
            return CurrentTemplate(model);
        }

        #endregion
    }
}
