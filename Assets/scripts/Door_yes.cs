using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_yes : MonoBehaviour
{
    private bool isClicked = false; // �t���O��ǉ�
    [SerializeField] Animator animator = default;
    //[SerializeField] Animator animator2 = default;
    [SerializeField] GameObject button_yes;
    [SerializeField] GameObject button_no;

    // �t���O��ݒ肷�郁�\�b�h
    public void SetClicked(bool clicked)
    {
        isClicked = clicked;
    }

    // �X�V����
    public void OnClick()
    {
       
        animator.Play("DoorOpen");
        //animator2.Play("CameraZoom");

        /*if (animator2 != null)
        {
            StartCoroutine(WaitForDoorAnimationAndZoom());
        }*/
        button_yes.SetActive(false);
        button_no.SetActive(false);
        UnityEngine.Debug.LogError("CLEAR");
        SceneManager.LoadScene("Clear"); // �J�ڂ���V�[�����𐳊m�Ɏw�肵�Ă�������
    }

   
}
