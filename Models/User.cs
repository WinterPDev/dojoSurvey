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
        public string Name {get;set;}
        [Required]
        public string Location {get;set;}
        [Required]
        public string Language {get;set;}
        public string Comment {get;set;}

    }


}