﻿namespace BlogSecurity.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }    
        public string Content { get; set; }
        public string ImagePath { get; set; }
        public bool IsPublish { get; set; } 

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public User User { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; } 

    }
}
