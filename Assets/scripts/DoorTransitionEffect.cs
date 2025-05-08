using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTransitionEffect : MonoBehaviour
{
    public CameraManager cameraManager; // CameraManager�̎Q��
    public int zoomPositionIndex;       // �Y�[����̃J�����ʒu�̃C���f�b�N�X
    public float zoomSpeed = 2f;        // �Y�[�����x
    public string nextSceneName;        // �J�ڂ���V�[���̖��O

    private bool isZooming = false;

    public void StartDoorTransition()
    {
        if (!isZooming)
        {
            StartCoroutine(ZoomToDoorAndTransition());
        }
    }

    private IEnumerator ZoomToDoorAndTransition()
    {
        isZooming = true;

        // Cube �J������ Transform ���擾
        Transform cameraTransform = Camera.main.transform;

        // �Y�[���^�[�Q�b�g�� Transform ���擾
        Transform targetPosition = cameraManager.cameraPositions[zoomPositionIndex];

        while (Vector3.Distance(cameraTransform.position, targetPosition.position) > 0.1f)
        {
            // Cube �J�������^�[�Q�b�g�ʒu�Ɍ������Ĉړ�������
            cameraTransform.position = Vector3.MoveTowards(cameraTransform.position, targetPosition.position, zoomSpeed * Time.deltaTime);
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, targetPosition.rotation, zoomSpeed * Time.deltaTime);
            yield return null;
        }

        // �V�[���J��
        SceneManager.LoadScene(nextSceneName);
    }
}
