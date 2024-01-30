using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    private readonly int Walk = Animator.StringToHash(nameof(Walk));
    private readonly int Run = Animator.StringToHash(nameof(Run));
    private readonly int Jump = Animator.StringToHash(nameof(Jump));

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetWalkAnimation(bool isPlayAnimation)
    {
        Animations(Walk, isPlayAnimation);
    }

    public void SetRunAnimation(bool isPlayAnimation)
    {
        Animations(Run, isPlayAnimation);
    }

    public void SetJumpAnimation(bool isPlayAnimation)
    {
        Animations(Jump, isPlayAnimation);
    }

    private void Animations(int nameParameters, bool isPlayAnimation)
    {
        _animator.SetBool(nameParameters, isPlayAnimation);
    }
}