﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnAPIWithJWT.Model
{
    public class JsonResponse
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
