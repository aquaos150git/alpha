using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateOnHandInput : MonoBehaviour
{
    public InputActionProperty pinchAnimatinAction;
    public InputActionProperty gripAnimationAction;
    public Animator handAnimator;

    void Update()
    {
        float triggerValue = pinchAnimatinAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        float gripvalue = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripvalue);
    }
}
