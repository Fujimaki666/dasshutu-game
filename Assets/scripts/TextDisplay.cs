using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 🔹シーン遷移のために追加

public class TextDisplay : MonoBehaviour
{
    public string[] texts;      // テキスト配列
    int textNumber;             // 現在表示中のテキスト番号
    string displayText;         // 表示されるテキスト
    int textCharNumber;         // 現在表示中の文字番号
    int displayTextSpeed;       // 文字を表示するスピード制御用
    bool click;                 // クリックされたかのフラグ
    bool textStop;              // テキスト表示が終わったかどうかのフラグ
    bool isRestarting;          // リスタート中かどうかを管理
    [SerializeField] GameObject panel;

    [SerializeField] private string Clear; // 🔹 次のシーン名
    [SerializeField] private string Clear1; // 🔹 遷移させたいシーン名
    [SerializeField] private string Start1; // 🔹 次のシーン名
    [SerializeField] private string Main1; // 🔹 遷移させたいシーン名

    void Start()
    {
        StartTextDisplay(); // 初期化時にテキスト表示をスタート
    }

    void Update()
    {
        if (!textStop)
        {
            displayTextSpeed++;

            // 5フレームごとに1文字ずつ表示する
            if (displayTextSpeed % 5 == 0)
            {
                if (textCharNumber < texts[textNumber].Length)
                {
                    displayText += texts[textNumber][textCharNumber];
                    textCharNumber++;
                }
                else
                {
                    if (textNumber < texts.Length - 1)
                    {
                        if (click)
                        {
                            displayText = "";  // 次のセリフに切り替え
                            textCharNumber = 0;
                            textNumber++;
                        }
                    }
                    else
                    {
                        // 🔹 最後のテキストが終わったら遷移判定
                        if (click)
                        {
                            textStop = true;
                            panel.SetActive(false);

                            // 🔹 特定のシーン名のときだけ遷移する
                            if (SceneManager.GetActiveScene().name == Clear)
                            {
                                if (!string.IsNullOrEmpty(Clear1))
                                {
                                    SceneManager.LoadScene(Clear1);
                                }
                            }
                            if (SceneManager.GetActiveScene().name == Start1)
                            {
                                if (!string.IsNullOrEmpty(Main1))
                                {
                                    SceneManager.LoadScene(Main1);
                                }
                            }
                        }
                    }
                }

                this.GetComponent<Text>().text = displayText;
                click = false; // クリックフラグをリセット
            }

            if (Input.GetMouseButton(0))
            {
                click = true;
            }
        }
    }

    public void RestartTextDisplay()
    {
        Debug.Log("TextDisplay restarting from the beginning.");
        textNumber = 0;
        textCharNumber = 0;
        displayText = "";
        displayTextSpeed = 0;
        textStop = false;
        isRestarting = false;
        this.GetComponent<Text>().text = displayText;
        panel.SetActive(true);
    }

    public void StartTextDisplay()
    {
        textNumber = 0;
        displayText = "";
        textCharNumber = 0;
        displayTextSpeed = 0;
        click = false;
        textStop = false;
        isRestarting = false;
        this.GetComponent<Text>().text = displayText;
        panel.SetActive(true);
    }
}
