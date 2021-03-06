﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peng04.processing
{
    public interface ILanguageProcessor
    {
        TextSource Process(IEnumerable<string> documents);

        TextSource Process(IEnumerable<string> documents, string name);
    }
}