using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots = default;
    //[SerializeField] GameObject Panel4;

    //�ǂ�����ł��A�N�Z�X�ł���悤�ɂ���ϐ�
    public static ItemBox instance;
    Slot selectSlot;
    private Item.Type selectedItemType;
    private void Awake()
    {
        instance = this;
    }
    //�N���b�N�������A�C�e�����󂯎��
    public void SetItem(Item.Type type ) //public void SetItem(Item.Type type)
    {
        
            Item item = ItemDatabase.instance.Spawn(type);
            for (int i = 0; i < slots.Length; i++)
            {
                Slot slot = slots[i];
                if (slot.IsEmpty())
                {
                    slot.Set(item);
                    
                    break;
                }
            }
        
    }
    public void OnSlotClick(int position)
    {
        //�A�C�e�����Ȃ��ꍇ���s���Ȃ�
        if (slots[position].IsEmpty())
        {
            return;
        }
        //��xBackPanel��S�ď���
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].HideBackPanel();

        }
        //�N���b�N�����X���b�g��BackPanel��\������
        slots[position].OnSelect();
        //�I���A�C�e���Ƃ��Ď擾����
        selectSlot = slots[position];

        // �I�����ꂽ�A�C�e���̎�ނ�ݒ�
        selectedItemType = selectSlot.GetItem().type;
        
    }

    //�A�C�e����I�����Ă��邩�𔻒肷��֐�
    public bool CheckSelectItem(Item.Type useItemType)
    {
        if (selectSlot == null)
        {
            return false;

        }
        if (selectSlot.GetItem().type == useItemType)
        {
            return true;
        }
        

        return false;

    }

    public void UseSelectItem()
    {
        selectSlot.RemoveItem();
        selectSlot = null;
    }
}
