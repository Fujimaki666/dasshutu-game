using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesbutton : MonoBehaviour
{
    [SerializeField] GameObject kansi;
    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    [SerializeField] DoorManager doorManager;
    
    // Start is called before the first frame update
    public void OnClick()
    {
        kansi.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);

        doorManager.SetClicked(true);//Setclicked�̃t���O��true�ɂ��Ă���
        //DoorManager.SetClicked(true);
        Debug.Log("�����ꂽ!");  // ���O���o��
    }
    
}
