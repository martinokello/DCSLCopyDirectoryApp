﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyDirectoryEngine.Interfaces
{
    public interface IProgress
    {
        decimal Progress
        {
            get; set;
        }

    }
}
