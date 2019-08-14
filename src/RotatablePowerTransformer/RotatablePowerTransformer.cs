﻿using Harmony;
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedParameter.Local

namespace MightyVincent
{
    [HarmonyPatch(typeof(PowerTransformerConfig), "CreateBuildingDef")]
    public class PowerTransformerConfigPatch
    {
        public static void Postfix(BuildingDef __result)
        {
            __result.PermittedRotations = PermittedRotations.R360;
            __result.BuildLocationRule = BuildLocationRule.OnFloorOrBuildingAttachPoint;
        }
    }

    [HarmonyPatch(typeof(PowerTransformerSmallConfig), "CreateBuildingDef")]
    public class PowerTransformerSmallConfigPatch
    {
        public static void Postfix(BuildingDef __result)
        {
            __result.PermittedRotations = PermittedRotations.R360;
            __result.BuildLocationRule = BuildLocationRule.OnFloorOrBuildingAttachPoint;
        }
    }
}