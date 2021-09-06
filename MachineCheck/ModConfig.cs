using StardewModdingAPI.Utilities;

namespace MachineCheck
{
    class ModConfig
    {
        public KeybindList ToggleKey { get; set; } = KeybindList.Parse("J");
        public bool AutoUnsave { get; set; } = false;
    }
}
