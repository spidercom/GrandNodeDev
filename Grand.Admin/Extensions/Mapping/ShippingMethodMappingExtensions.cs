﻿using Grand.Domain.Shipping;
using Grand.Admin.Models.Shipping;

namespace Grand.Admin.Extensions
{
    public static class ShippingMethodMappingExtensions
    {
        public static ShippingMethodModel ToModel(this ShippingMethod entity)
        {
            return entity.MapTo<ShippingMethod, ShippingMethodModel>();
        }

        public static ShippingMethod ToEntity(this ShippingMethodModel model)
        {
            return model.MapTo<ShippingMethodModel, ShippingMethod>();
        }

        public static ShippingMethod ToEntity(this ShippingMethodModel model, ShippingMethod destination)
        {
            return model.MapTo(destination);
        }
    }
}