﻿using System.Collections.Generic;

namespace LyncUCWA.JsonResponses
{
    public class Communication : ClsHref
    {
        public Link _links { get; set; }
        public List<string> supportedModalities { get; set; }
        public List<string> supportedMessageFormats { get; set; }
        public string etag { get; set; }
    }
}