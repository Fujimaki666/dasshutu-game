using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    
    [SerializeField] GameObject button;

    // フラグを設定するメソッド
   

    // 更新処理
    public void OnClick()
    {

        
        SceneManager.LoadScene("Start"); // 遷移するシーン名を正確に指定してください
    }

}
