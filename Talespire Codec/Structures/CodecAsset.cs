﻿using System;
using System.Collections.Generic;

namespace Talespire_Codec
{
    [Serializable]
    public class CodecAsset
    {
        public string uuid { get; set; }
        public int instanceCount { get; set; }
        public List<Position> instances { get; set; }
    };
}
