using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    
    [SerializeField] GameObject button;

    // �t���O��ݒ肷�郁�\�b�h
   

    // �X�V����
    public void OnClick()
    {

        
        SceneManager.LoadScene("Start"); // �J�ڂ���V�[�����𐳊m�Ɏw�肵�Ă�������
    }

}
