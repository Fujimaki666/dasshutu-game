using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class curry : MonoBehaviour
{
    [SerializeField] GameObject Curry;
    // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    public Item.Type type = default;
    // Start is called before the first frame update
    private bool hasClicked = false;
    public void ItemClick1()
    {
        if (!hasClicked) // Key���擾���Ă��Ȃ��ꍇ�̂ݎ��s
        {
            Item item = ItemDatabase.instance.Spawn(type);
            ItemBox.instance.SetItem(type);
            Debug.Log("aaa");
            Curry.SetActive(true);
            panel.SetActive(true);
            hasClicked = true;
        }
    }
    public void ItemClose1()
    {
        Debug.Log("bbb");
        Destroy(this.gameObject);
        //get_Key.SetActive(true);
    }
    /*public void SetKeyAcquired()
    {
        hasKey = true; // Key���擾�������Ƃ��t���O�ŋL�^
        Key.SetActive(true);
    }*/
}
