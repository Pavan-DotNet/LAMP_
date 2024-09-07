﻿using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class List
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string? Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
