using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using eManager.Domain;

namespace eManager.Web.Models
{
    public class CreateGameViewModel
    {
        [HiddenInput(DisplayValue=false)]
        public int GameId { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required]
        public Team Home { get; set; }
        [Required]
        public IQueryable<Team> Teams { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? GameTime { get; set; }
    }
}