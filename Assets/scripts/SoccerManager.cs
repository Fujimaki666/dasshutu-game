using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerManager : MonoBehaviour
{
    [SerializeField] GameObject soccerButton = default; // �\������{�^��
    [SerializeField] GameObject soccerButton2 = default; // �\������{�^��
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panel_osu;
    [SerializeField] TextDisplay textDisplay;

    private bool hasClicked = false;

    public void ItemClick()
    {

        
        // �T�b�J�[�A�C�e�����I������Ă��邩�m�F
        if (ItemBox.instance.CheckSelectItem(Item.Type.Soccer))
        {
                // �{�^����\��
                soccerButton.SetActive(true);
                soccerButton2.SetActive(true);
                Debug.Log("Soccer item selected.");
                panel_osu.SetActive(true);
                textDisplay.RestartTextDisplay();
        }
            else
            {
                panel.SetActive(true);
                Debug.Log("Soccer item not selected.");
            }

            hasClicked = true; // ��x�ڈȍ~�͎��s���Ȃ�
        
    }

    public void ItemClose()
    {
        Debug.Log("Button closed.");
        Destroy(this.gameObject);
    }
}
