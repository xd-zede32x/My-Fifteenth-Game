using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetAnimations(PlayerAnimationType animationType, bool isPlayAnimation)
    {
        int parameterHash = Animator.StringToHash(animationType.ToString());
        _animator.SetBool(parameterHash, isPlayAnimation);
    }
}