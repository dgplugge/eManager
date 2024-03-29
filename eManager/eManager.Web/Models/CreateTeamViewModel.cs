﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace eManager.Web.Models
{
    public class CreateTeamViewModel
    {
        [HiddenInput(DisplayValue=false)]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}