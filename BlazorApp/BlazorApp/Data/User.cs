﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public partial class User
    {
        public int UserId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public short JobId { get; set; }
        public byte? JobLevel { get; set; }
        public int PubId { get; set; }
        public DateTime HireDate { get; set; }
        public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}
