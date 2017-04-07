using System;
using System.Collections.Generic;
using System.Text;

namespace ComsoleApp
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)  // Multiuse attribute.  
]

    public class BaseData : System.Attribute
    {
        string name;
        public double version;

        public BaseData(string name)
        {
            this.name = name;

            // Default value.  
            version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }

    [BaseData("P. Ackerman")]
    public class FirstClass
    {
        // ...  
    }
}
