﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEvernote.Common
{
    [Table("Users")]
    public class EvernoteUser:EntityBase
    {
        [Required,StringLength(25)]
        public string Name { get; set; }

        [Required, StringLength(25)]
        public string Surname { get; set; }

        [Required, StringLength(25)]
        public string Username { get; set; }

        [Required,StringLength(70),EmailAddress]
        public string Email { get; set; }

        [Required,StringLength(100)]
        public string Password { get; set; }

        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        [Required]
        public Guid ActivateGuid { get; set; }

        

        public virtual List<Note>  Notes { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Liked> Likes { get; set; }
    }
}
