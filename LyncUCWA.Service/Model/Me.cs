﻿namespace LyncUCWA.Service.Model
{
    public class Me : ClsHref
    {
        public string name { get; set; }
        public string uri { get; set; }
        public Link _links { get; set; }
    }
}
