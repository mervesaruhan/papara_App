﻿namespace papara_firstweek_hwApp.API.Models.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;    
        public int Age { get; set; }
    }
}
