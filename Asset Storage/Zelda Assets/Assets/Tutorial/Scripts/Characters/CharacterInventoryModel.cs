﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterInventoryModel : MonoBehaviour
{
    private CharacterMovementModel m_MovementModel;

    Dictionary<ItemType, int> m_Items = new Dictionary<ItemType, int>();

    void Awake()
    {
        m_MovementModel = GetComponent<CharacterMovementModel>();
    }

    public int GetItemCount( ItemType itemType )
    {
        if( m_Items.ContainsKey( itemType ) == false )
        {
            return 0;
        }

        return m_Items[ itemType ];
    }

    public void AddItem( ItemType itemType, PickupType pickupType )
    {
        AddItem( itemType, 1, pickupType );
    }

    public void AddItem( ItemType itemType, int amount, PickupType pickupType )
    {
        if( m_Items.ContainsKey( itemType ) == true )
        {
            m_Items[ itemType ] += amount;
        }
        else
        {
            m_Items.Add( itemType, amount );
        }

        if( amount > 0 )
        {
            ItemData itemData = Database.Item.FindItem( itemType );

            if( itemData != null )
            {
                

                if( itemData.GetPickupAnimation( pickupType ) != ItemData.PickupAnimation.None )
                {
                    m_MovementModel.ShowItemPickup( itemType, pickupType );
                }

                if( itemData.IsEquipable == ItemData.EquipPosition.SwordHand )
                {
                    m_MovementModel.EquipWeapon( itemType );
                }
                else if( itemData.IsEquipable == ItemData.EquipPosition.ShieldHand )
                {
                    m_MovementModel.EquipShield( itemType );
                }
            }
        }
    }
}
