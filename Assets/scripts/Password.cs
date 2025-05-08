using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Password : MonoBehaviour
{
    [SerializeField] GameObject kinko;
    [SerializeField] GameObject fieldObj;
    [SerializeField] GameObject Key;
    [SerializeField] GameObject panel_bed;
    [SerializeField] TextDisplay textDisplay;

    // [SerializeField] GameObject get_Key;

    [SerializeField] GameObject panel_false;
    [SerializeField] GameObject panel;
    public Item.Type type = default;
    // Start is called before the first frame update
    private bool hasClicked = false;
    private InputField inputField;

    void Start()
    {
        fieldObj = GameObject.Find("InputField");
        inputField = fieldObj.GetComponent<InputField>();
        kinko = GameObject.Find("kinko");
        EventTrigger trigger = fieldObj.AddComponent<EventTrigger>();

        // Entry���쐬���A�N���b�N�C�x���g��ݒ�
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerClick;
        entry.callback.AddListener((data) => { OnInputFieldClicked(); });
        trigger.triggers.Add(entry);


    }
    void OnInputFieldClicked()
    {
        panel_bed.SetActive(false);
    }

    public void InputText()
    {
       
        if (inputField.text == "���߂łƂ�")
        {
            kinko.SetActive(false);
            fieldObj.SetActive(false);
            Item item = ItemDatabase.instance.Spawn(type);
            ItemBox.instance.SetItem(type);
            Debug.Log("aaa");
            Key.SetActive(true);
            panel.SetActive(true);
            hasClicked = true;

        }
        else
        {
            kinko.SetActive(false);
            fieldObj.SetActive(false);
            panel_false.SetActive(true);
            textDisplay.RestartTextDisplay();
        }

    }
}
