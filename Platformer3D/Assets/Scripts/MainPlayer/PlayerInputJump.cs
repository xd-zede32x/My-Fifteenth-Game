using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerJump))]
public class PlayerInputJump : MonoBehaviour
{
    private PlayerJump _playerJump;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerJump = GetComponent<PlayerJump>();
    }

    public void InputJump(PlayerAnimations playerAnimation, float jumpForce)
    {
        bool shouldJump = IsGrounded()  && Input.GetKeyDown(KeyCode.Space);

        if (shouldJump)
        {
            _playerJump.Jump(_rigidbody, jumpForce);
            playerAnimation.SetJumpAnimations(true);
        }

        else
        {
            playerAnimation.SetJumpAnimations(false);
        }
    }

    private bool IsGrounded()
    {
        float recastDistance = 0.1f;
        RaycastHit hits;

        return Physics.Raycast(transform.position, Vector3.down, out hits, recastDistance);
    }
}