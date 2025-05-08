using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    [SerializeField] GameObject Button1 = default; // Door_Yes�{�^��
    [SerializeField] GameObject Button2 = default;// Door_No�{�^��
    [SerializeField] GameObject Panel_door = default; // �\������{�^��
    [SerializeField] GameObject Panel_door_deru = default; // �\������{�^��
    [SerializeField] TextDisplay textDisplay;

    private bool isClicked = false;

    public void SetClicked(bool clicked)
    {
        isClicked = clicked;
    }

    public void OnClick()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.key) && isClicked == true)
        {
            Button1.SetActive(true);
            Button2.SetActive(true);
            //Debug.Log("CLEAR");
            Panel_door_deru.SetActive(true);
            Debug.Log("������!!!");

        }
        else
        {
            Panel_door.SetActive(true);
            textDisplay.RestartTextDisplay();

        }


        Debug.Log("�����ꂽ!!!");  // ���O���o��

    }
        

    
}
