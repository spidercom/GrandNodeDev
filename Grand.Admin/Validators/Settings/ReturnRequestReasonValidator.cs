﻿using FluentValidation;
using Grand.Core.Validators;
using Grand.Services.Localization;
using Grand.Admin.Models.Settings;
using System.Collections.Generic;

namespace Grand.Admin.Validators.Settings
{
    public class ReturnRequestReasonValidator : BaseGrandValidator<ReturnRequestReasonModel>
    {
        public ReturnRequestReasonValidator(
            IEnumerable<IValidatorConsumer<ReturnRequestReasonModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name.Required"));
        }
    }
}