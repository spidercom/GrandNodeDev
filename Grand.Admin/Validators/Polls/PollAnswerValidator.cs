﻿using FluentValidation;
using Grand.Core.Validators;
using Grand.Services.Localization;
using Grand.Admin.Models.Polls;
using System.Collections.Generic;

namespace Grand.Admin.Validators.Polls
{
    public class PollAnswerValidator : BaseGrandValidator<PollAnswerModel>
    {
        public PollAnswerValidator(
            IEnumerable<IValidatorConsumer<PollAnswerModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Answers.Fields.Name.Required"));
        }
    }
}