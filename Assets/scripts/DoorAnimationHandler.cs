using UnityEngine;

public class DoorAnimationHandler : StateMachineBehaviour
{
    private DoorTransitionEffect doorTransitionEffect;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        // �h�A�̃g�����W�V�������ʂ��J�n
        if (doorTransitionEffect == null)
        {
            // Animator �� GameObject ���� DoorTransitionEffect ��T��
            doorTransitionEffect = animator.GetComponent<DoorTransitionEffect>();

            // �e�I�u�W�F�N�g�������̓V�[���S�̂���T��
            if (doorTransitionEffect == null)
            {
                doorTransitionEffect = Camera.main?.GetComponent<DoorTransitionEffect>();
            }
        }

        if (doorTransitionEffect != null)
        {
            doorTransitionEffect.StartDoorTransition();
        }
    }
}
