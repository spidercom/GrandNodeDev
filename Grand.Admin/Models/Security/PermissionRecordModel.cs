﻿using Grand.Core.Models;

namespace Grand.Admin.Models.Security
{
    public partial class PermissionRecordModel : BaseModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
        public bool Actions { get; set; }
    }
}