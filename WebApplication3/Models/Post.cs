using System;

namespace WebApplication3.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Type { get; set; } = "";
        public string MsNo { get; set; } = "";
        public string As1 { get; set; } = "";
        public bool Keyboard { get; set; }
        public bool Mouse { get; set; }
        public string Srnnum { get; set; } = "";
        public string Scras { get; set; } = "";
        public string Scras2 { get; set; } = "";
        public bool Dstm { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}

