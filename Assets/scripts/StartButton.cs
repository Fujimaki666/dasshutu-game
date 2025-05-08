using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnClick()
    {


        SceneManager.LoadScene("Start1"); // 遷移するシーン名を正確に指定してください
    }
}
