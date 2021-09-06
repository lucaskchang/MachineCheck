using System.Collections.Generic;

namespace MachineCheck
{
    class ModData
    {
        public IDictionary<string, Dictionary<string, string>> MachineChecks { get; set; } = new Dictionary<string, Dictionary<string, string>>();
    }
}
