﻿using System;
using gym_project_business_logic.Model.Enum;

namespace gym_project_business_logic.Model.Domains
{
    public class DTOCoach
    {
        public string FullName { get; set; } = null!;

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Gender { get; set; } = null!;

        public TrainerSpecializationEnum Specialization { get; set; }

        public TrainerStatusEnum Status { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public string? WorkingTime { get; set; }
    }
}
