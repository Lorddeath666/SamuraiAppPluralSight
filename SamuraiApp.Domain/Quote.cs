﻿namespace SamuraiApp.Domain
{
    public class Quote
    {

        //test
        public int Id { get; set; }
        public string Text { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
    }
}
