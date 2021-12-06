using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.ComponentModel.DataAnnotations;

namespace dojoSurvey.Models
{
    public class User
    {
        [Required]
        [MinLength(2)]
        public string Name {get;set;}
        [Required]
        public string Location {get;set;}
        [Required]
        public string Language {get;set;}
        [MinLength(20)]
        public string Comment {get;set;}

    }


}