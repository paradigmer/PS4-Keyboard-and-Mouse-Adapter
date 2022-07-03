﻿using System.Collections.Generic;

namespace Pizza.KeyboardAndMouseAdapter.Backend.Mappings
{
    public class PhysicalKeyGroup
    {
        public List<PhysicalKey> PhysicalKeys;

        public PhysicalKeyGroup()
        {
            PhysicalKeys = new List<PhysicalKey>();
        }

        public override string ToString()
        {
            return ListUtil.ListToString(PhysicalKeys);
        }
    }
}