using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string SecondName { get; set; } = "";
        public string Type { get; set; } = "";
        public string AssetNumber { get; set; } = "";
        public string Screen { get; set; } = "";
        public string AssetNumbers { get; set; } = "";
        public bool HeadsetIncluded { get; set; }
        public bool KeyboardMouse { get; set; }
        public bool DockingStation { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;
    }
}

