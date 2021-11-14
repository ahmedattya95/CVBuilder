﻿namespace CVBuilder.Models;
public class CVValidator : AbstractValidator<CV>
{
    public CVValidator()
    {
        RuleFor(x => x.PersonalData).SetValidator(new PersonValidator());
        RuleForEach(x => x.Educations).SetValidator(new EducationValidator());
        RuleForEach(x => x.WorkExperience).SetValidator(new ExperienceValidator());
        RuleForEach(x => x.OtherExperience).SetValidator(new ExperienceValidator());
        RuleForEach(x => x.Refernces).SetValidator(new ReferncesValidator());
    }
}

