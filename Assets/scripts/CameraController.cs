using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class CameraController : MonoBehaviour
{
    public GameObject cameraObject;  // ��A�N�e�B�u�̃J�����I�u�W�F�N�g
    public Transform target;         // �J�������������^�[�Q�b�g
    public float speed = 2.0f;       // �J�����̈ړ����x

    public void StartMovingCamera()
    {
        // Coroutine�ŃJ�����𓮂���
        StartCoroutine(MoveCameraCoroutine());
    }

    private IEnumerator MoveCameraCoroutine()
    {
        // �J�������^�[�Q�b�g�ɏ\���߂Â��܂ňړ��𑱂���
        while (Vector3.Distance(cameraObject.transform.position, target.position) > 0.1f)
        {
            cameraObject.transform.position = Vector3.MoveTowards(cameraObject.transform.position, target.position, speed * Time.deltaTime);
            yield return null;  // ���̃t���[���܂őҋ@
        }

        //Debug.Log("Camera reached target.");
    }
}
