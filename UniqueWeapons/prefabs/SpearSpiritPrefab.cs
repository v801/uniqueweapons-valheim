﻿using JotunnLib.Entities;

namespace UniqueWeapons
{
    public class SpearSpiritPrefab : PrefabConfig
    {
        public SpearSpiritPrefab() : base("v801_SpearSpirit", "v801_SpearSpirit_bundle")
        {

        }

        public override void Register()
        {
            ItemDrop item = Prefab.GetComponent<ItemDrop>();
            item.m_itemData.m_shared.m_itemType = ItemDrop.ItemData.ItemType.OneHandedWeapon;
            item.m_itemData.m_shared.m_name = "Spiritine, the Primordial Impaler";
            item.m_itemData.m_shared.m_description = "Even the old ones have forgotten.";
            item.m_itemData.m_dropPrefab = Prefab;
            item.m_itemData.m_shared.m_maxStackSize = 1;
            item.m_itemData.m_shared.m_maxQuality = 1;
            item.m_itemData.m_shared.m_maxDurability = 500;
            item.m_itemData.m_shared.m_equipDuration = 0.2f;
            item.m_itemData.m_shared.m_variants = 1;
            item.m_itemData.m_shared.m_timedBlockBonus = 1;
            item.m_itemData.m_shared.m_deflectionForce = 1;
            item.m_itemData.m_shared.m_attackForce = 12;
            item.m_itemData.m_shared.m_attack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAnimation = "atgeir_attack";
            item.m_itemData.m_shared.m_secondaryAttack.m_attackChainLevels = 3;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackStamina = 20;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactor = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_speedFactorRotation = 0.2f;
            item.m_itemData.m_shared.m_secondaryAttack.m_damageMultiplier = 1f;
            item.m_itemData.m_shared.m_secondaryAttack.m_forceMultiplier = 10;
            item.m_itemData.m_shared.m_secondaryAttack.m_staggerMultiplier = 6;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRange = 3.5f;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackAngle = 180;
            item.m_itemData.m_shared.m_secondaryAttack.m_attackRayWidth = 0.3f;
            item.m_itemData.m_shared.m_secondaryAttack.m_lowerDamagePerHit = false;
            item.m_itemData.m_shared.m_damages.m_pierce = 75;
            item.m_itemData.m_shared.m_damages.m_spirit = 75;
        }
    }
}