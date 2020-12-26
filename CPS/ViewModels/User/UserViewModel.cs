using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CPS.ViewModels.User
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string PhoneNumber { get; set; }       

    }

    public class UserViewModelValidator:AbstractValidator<UserViewModel>
    {
        public UserViewModelValidator()
        {
            RuleFor(x => x.FirstName).NotNull();
            RuleFor(x => x.LastName).NotNull();
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.Password).NotNull().Length(8, 999).WithMessage("Enter minimum 8 charactors for password field");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password);
            RuleFor(x => x.PhoneNumber).NotNull().MinimumLength(10).MaximumLength(10); ;
        }
    }
}