using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 10.0f;
    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                isMoving = false;
                gameObject.SetActive(false); // �ړ�������������Ăє�A�N�e�B�u�ɂ���
            }
        }
    }

    public void StartMoving()
    {
        gameObject.SetActive(true); // �J�������A�N�e�B�u��
        isMoving = true;
    }
}
