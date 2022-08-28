﻿using System.ComponentModel.DataAnnotations;

namespace UniversityApiBE.Models.DataModels
{
    public class User : BaseEntity
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public virtual Student Student { get; set; }
    }
}
