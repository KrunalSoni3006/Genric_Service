using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Genric_Service
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)
]
    public class BeforeCodeAttribute : Attribute
    {
        public string Name { get; private set; }
        public BeforeCodeAttribute(string name)
        {
            Name = name;
        }
    }
}