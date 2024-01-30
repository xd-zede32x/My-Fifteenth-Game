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
        bool isGrounded = IsGrounded();
        bool shouldJump = isGrounded && Input.GetKeyDown(KeyCode.Space);

        if (shouldJump)
        {
            _playerJump.Jump(_rigidbody, jumpForce);
            playerAnimation.SetJumpAnimation(true);
        }

        else
            playerAnimation.SetJumpAnimation(false);
    }

    private bool IsGrounded()
    {
        float recastDistance = 0.1f;
        RaycastHit[] hits = new RaycastHit[1];

        return Physics.RaycastNonAlloc(transform.position, Vector3.down, hits, recastDistance) > 0;
    }
}