namespace TelerikRSS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Channel
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public List<Item> Item { get; set; }
    }
}