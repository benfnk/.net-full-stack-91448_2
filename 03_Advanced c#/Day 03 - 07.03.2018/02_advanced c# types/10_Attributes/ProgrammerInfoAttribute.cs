using System;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct |
        AttributeTargets.Enum, AllowMultiple = true, Inherited = false)]
    class ProgrammerInfoAttribute : Attribute
    {
        public string ProgrammerName;
        public string ProgrammingDate;

        public ProgrammerInfoAttribute(string programmingName, string programmingDate)
        {
            ProgrammerName = programmingName;
            ProgrammingDate = programmingDate;
        }
    }
}
