﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OutOfTimePrototype.Dal.Models;
using OutOfTimePrototype.DAL.Models;
using OutOfTimePrototype.DTO;
using System.ComponentModel.DataAnnotations;

namespace OutOfTimePrototype.Dto
{
    public class UserDto : IValidatable
    {
        public Guid Id { get; set; }

        [EmailAddress] public string Email { get; set; }

        public string? Password { get; set; }

        public AccountType AccountType { get; set; }

        public List<Role> ClaimedRoles { get; set; } = new List<Role>();
        public List<Role> VerifiedRoles { get; set; } = new List<Role>();

        // Person properties >>>
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        // <<< Person properties

        // Student properties >>>
        public string? GradeBookNumber { get; set; }
        public string? ClusterNumber { get; set; }

        // <<< Student properties

        // Student properties >>>
        public EducatorDto? ScheduleSelf { get; set; }

        // <<< Student properties

        public UserDto() { }

        public UserDto(User user)
        {
            Id = user.Id;
            Email = user.Email;
            //Password = user.Password;
            AccountType = user.AccountType;
            ClaimedRoles = user.ClaimedRoles;
            VerifiedRoles = user.VerifiedRoles;
            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            GradeBookNumber = user.GradeBookNumber;
            ClusterNumber = user.Cluster?.Number;
            ScheduleSelf = user.ScheduleSelf != null ? new EducatorDto(user.ScheduleSelf) : null;
        }

        // Исходя из того, что написано внутри, этот метод выглядит бесполезно
        public ModelStateDictionary Validate()
        {
            var result = new ModelStateDictionary();

            // Не вижу смысла в подобных общих ошибках, так как их отлично обрабатывают аннотации
            if (!new EmailAddressAttribute().IsValid(Email))
            {
                result.AddModelError("email", $"'{Email}' is not a valid Email address");
            }

            // Я не нашёл кейса когда, нам нужна будет валидация в зависимости от типа аккаунта, так как все
            // специфичные поля могут быть null 
            // switch (AccountType)
            // {
            //     case AccountType.Student:
            //         if (ClusterNumber is null)
            //         {
            //             result.AddModelError("clusterNumber", "field cannot be null");
            //         }
            //         
            //         break;
            //     case AccountType.Educator:
            // }

            return result;
        }
    }
}