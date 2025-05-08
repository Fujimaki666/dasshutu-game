using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]//inspector�ŕ\���ł���悤�ɂ���
public class Item
{
    //�A�C�e���̎��
    public enum Type
    {
        key,
        Soccer,
        Book,
        curry,
        onpu,
        Meron,
        Panel4,
        //�A�C�e����ǉ�����ꍇ�����ɏ�������
    }
    public Type type;
    public Sprite sprite;

    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }
}