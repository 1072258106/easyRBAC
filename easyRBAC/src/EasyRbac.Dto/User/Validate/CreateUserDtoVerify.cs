﻿using System;
using System.Collections.Generic;
using System.Text;
using EasyRbac.Dto.User;
using FluentValidation;

namespace EasyRbac.Dto.FluentValidate
{
    public class CreateUserDtoVerify:AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoVerify()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
            RuleFor(customer => customer.Password).Equal(customer => customer.ConfirmPassword);
            RuleFor(x => x.RealName).NotEmpty();
            RuleFor(x => x.MobilePhone).Matches("^1\\d{10}").WithMessage("手机格式不正确");
        }
    }
}
