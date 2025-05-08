using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject Key;
   // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject kinko;
    [SerializeField] GameObject fieldObj;
    [SerializeField] TextDisplay textDisplay;
    // public Item.Type type = default;
    // Start is called before the first frame update
    private bool hasClicked = false;
    public void ItemClick()
    {
        if (!hasClicked) // Key���擾���Ă��Ȃ��ꍇ�̂ݎ��s
        {
            kinko.SetActive(true);
            fieldObj.SetActive(true);
            panel.SetActive(true);
            textDisplay.RestartTextDisplay();


        }
    }
    public void ItemClose()
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
