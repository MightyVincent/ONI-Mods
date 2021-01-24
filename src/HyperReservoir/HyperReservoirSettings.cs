using Newtonsoft.Json;
using PeterHan.PLib;
using PeterHan.PLib.Options;

// ReSharper disable InconsistentNaming

namespace AsLimc.HyperReservoir {
    [ModInfo("AsLimc.HyperReservoir.LocStrings.Settings.MOD_NAME", "https://github.com/as-limc/oni-mods", collapse: true)]
    [JsonObject(MemberSerialization.OptIn)]
    [RestartRequired]
    public class HyperReservoirSettings {
        private static HyperReservoirSettings _Instance;
        public static HyperReservoirSettings Get() => _Instance;

        public static void Init() {
            _Instance ??= POptions.ReadSettings<HyperReservoirSettings>() ?? new HyperReservoirSettings();
        }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirSteelMassKg.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirSteelMassKg.TOOLTIP",
            null)]
        [JsonProperty]
        public float LiquidReservoirSteelMassKg { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirPlasticMassKg.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirPlasticMassKg.TOOLTIP",
            null)]
        [JsonProperty]
        public float LiquidReservoirPlasticMassKg { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirPowerConsumptionWatts.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirPowerConsumptionWatts.TOOLTIP",
            null)]
        [JsonProperty]
        public float LiquidReservoirPowerConsumptionWatts { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirCapacityMultiplier.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.LiquidReservoirCapacityMultiplier.TOOLTIP",
            null)]
        [JsonProperty]
        public float LiquidReservoirCapacityMultiplier { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirSteelMassKg.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirSteelMassKg.TOOLTIP",
            null)]
        [JsonProperty]
        public float GasReservoirSteelMassKg { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirPlasticMassKg.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirPlasticMassKg.TOOLTIP",
            null)]
        [JsonProperty]
        public float GasReservoirPlasticMassKg { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirPowerConsumptionWatts.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirPowerConsumptionWatts.TOOLTIP",
            null)]
        [JsonProperty]
        public float GasReservoirPowerConsumptionWatts { get; set; }

        [Option("AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirCapacityMultiplier.NAME",
            "AsLimc.HyperReservoir.LocStrings.Settings.GasReservoirCapacityMultiplier.TOOLTIP",
            null)]
        [JsonProperty]
        public float GasReservoirCapacityMultiplier { get; set; }

        public HyperReservoirSettings() {
            LiquidReservoirSteelMassKg = 800f;
            LiquidReservoirPlasticMassKg = 100f;
            LiquidReservoirPowerConsumptionWatts = 40f;
            LiquidReservoirCapacityMultiplier = 4;
            GasReservoirSteelMassKg = 800f;
            GasReservoirPlasticMassKg = 100f;
            GasReservoirPowerConsumptionWatts = 40f;
            GasReservoirCapacityMultiplier = 4;
        }

    }
}