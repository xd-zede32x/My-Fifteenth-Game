using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private readonly int Walk = Animator.StringToHash(nameof(Walk));
    private readonly int Run = Animator.StringToHash(nameof(Run));
    private readonly int Jump = Animator.StringToHash(nameof(Jump));

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetWalkAnimation(bool isPlayAnimation)
    {
        _animator.SetBool(Walk, isPlayAnimation);
    }

    public void SetJumpAnimation(bool isPlayAnimation)
    {
        _animator.SetBool(Jump, isPlayAnimation);
    }
}