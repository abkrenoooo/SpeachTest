﻿using SpeakEase.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Enum;

namespace SpeakEase.DAL.Entities
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public CharacterPosition? CharacterPosition { get; set; }
        public Character? Character { get; set; }
        public string? Word { get; set; }
        public string? Image { get; set; }
        public string? Audio { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsHidden { get; set; } = false;
    }
}
