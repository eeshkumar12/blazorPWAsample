﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary
{
    public class DataRepository
    {
        public string[] names = { "name1", "name2", "name3", "name4", "name5", "name6" };
        public string[] GetNames()
        {
            return names;
        }
    }

}
