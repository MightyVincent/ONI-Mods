using STRINGS;

// ReSharper disable UnusedType.Global
#pragma warning disable 414

namespace AsLimc.LaserTurret {
    internal static class LocStrings {
        public static class LaserTurret
        {
            public static readonly LocString NAME = UI.FormatAsLink("Laser Turret", nameof(LaserTurretConfig.ID));
            public static readonly LocString DESC = "Hey, you! Freeze!";
            public static readonly LocString EFFECT = $"Target and attack {UI.CODEX.CATEGORYNAMES.CREATURES} nearby. Needs {UI.FormatAsLink("Power", "POWER")} to work. " +
                                                      $"Can be controlled by <link=\"LOGIC\">Automation</link>.";
        }
    }
}