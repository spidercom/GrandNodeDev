﻿using Grand.Framework.Components;
using Grand.Services.Security;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Grand.Admin.Components
{
    public class OrderReportOrderTimeChartViewComponent : BaseAdminViewComponent
    {
        private readonly IPermissionService _permissionService;

        public OrderReportOrderTimeChartViewComponent(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageOrders))
                return Content("");

            return View();
        }
    }
}