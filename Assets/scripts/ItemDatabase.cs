using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    //�ǂ�����ł��A�N�Z�X�ł���悤�ɂ���
    public static ItemDatabase instance;

    public void Awake()
    {
        instance = this;
    }

    [SerializeField] ItemDatabaseEntity itemDatabaseEntity = default;
    //item�𐶐�
    public Item Spawn(Item.Type type)
    {
        for (int i = 0; i < itemDatabaseEntity.items.Count; i++)
        {
            Item itemData = itemDatabaseEntity.items[i];
            //�f�[�^�x�[�X�����v������̂�T��
            if (itemData.type == type)
            {
                return new Item(itemData);
                //��v�����琶�����ēn��
            }
        }
        return null;
    }
}