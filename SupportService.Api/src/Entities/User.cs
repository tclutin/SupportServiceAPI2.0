﻿
namespace SupportService.Api.src.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string Role { get; set; }
        public string? TelegramId { get; set; }
        public Guid? TicketId { get; set; }
        public int Rating { get; set; }
    }

}
