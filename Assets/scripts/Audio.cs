using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    // Start is called before the first frame update
    // �����i�[����ϐ�
    public AudioClip clickSound;

    // ��x�����Đ����邽�߂̃t���O
    private bool hasPlayed = false;

    // �N���b�N�����o���ꂽ�Ƃ��ɌĂ΂�郁�\�b�h
    private void OnMouseDown()
    {
        // �܂������Đ�����Ă��Ȃ��ꍇ
        if (!hasPlayed)
        {
            // �����Đ�����
            AudioSource.PlayClipAtPoint(clickSound, transform.position);
            // �Đ��t���O��ݒ肷��
            hasPlayed = true;
        }
    }
}
