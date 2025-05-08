using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button leftButton;
    public Button rightButton;
    public GameObject textBox;
    public GameObject objectBox; // �\���������I�u�W�F�N�g

    private bool isDisplayingTextOrObject;

    void Start()
    {
        // ������Ԃł̓{�^���𑀍�\�ɐݒ�
        SetButtonInteractable(true);
    }

    void Update()
    {
        // �e�L�X�g�܂��̓I�u�W�F�N�g���\������Ă��邩�`�F�b�N
        isDisplayingTextOrObject = textBox.activeSelf || objectBox.activeSelf;

        // �t���O�Ɋ�Â��ă{�^����L���܂��͖����ɐݒ�
        SetButtonInteractable(!isDisplayingTextOrObject);
    }

    void SetButtonInteractable(bool interactable)
    {
        leftButton.interactable = interactable;
        rightButton.interactable = interactable;
    }
}
