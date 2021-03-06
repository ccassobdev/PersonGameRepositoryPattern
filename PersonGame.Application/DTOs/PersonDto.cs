﻿using PersonGame.Domain.SharedKernel;

namespace PersonGame.Application.DTOs
{
    public class CreatePersonDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class ViewPersonDto : BaseEntity<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}