using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimations : MonoBehaviour
{
    private readonly int Walk = Animator.StringToHash(nameof(Walk));
    private readonly int Run = Animator.StringToHash(nameof(Run));
    private readonly int Jump = Animator.StringToHash(nameof(Jump));
    private readonly int Die = Animator.StringToHash(nameof(Die));
    private readonly int Down = Animator.StringToHash(nameof(Down));

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetWalkAnimations(bool isPlayAnimation)
    {
        SetAnimations(Walk, isPlayAnimation);
    }

    public void SetRunAnimations(bool isPlayAnimation)
    {
        SetAnimations(Run, isPlayAnimation);
    }

    public void SetJumpAnimations(bool isPlayAnimation)
    {
        SetAnimations(Jump, isPlayAnimation);
    }

    public void SetDieAnimations(bool isPlayAnimation)
    {
        SetAnimations(Die, isPlayAnimation);
    }

    public void SetDownAnimations(bool isPlayAnimation)
    {
        _animator.SetBool(Down, isPlayAnimation);
    }

    private void SetAnimations(int nameParameters, bool isPlayAnimation)
    {
        _animator.SetBool(nameParameters, isPlayAnimation);
    }
}