﻿using Grand.Domain.Catalog;
using Grand.Admin.Models.Templates;

namespace Grand.Admin.Extensions
{
    public static class ProductTemplateMappingExtensions
    {
        public static ProductTemplateModel ToModel(this ProductTemplate entity)
        {
            return entity.MapTo<ProductTemplate, ProductTemplateModel>();
        }

        public static ProductTemplate ToEntity(this ProductTemplateModel model)
        {
            return model.MapTo<ProductTemplateModel, ProductTemplate>();
        }

        public static ProductTemplate ToEntity(this ProductTemplateModel model, ProductTemplate destination)
        {
            return model.MapTo(destination);
        }
    }
}