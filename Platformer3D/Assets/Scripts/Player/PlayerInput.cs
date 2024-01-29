using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private PlayerJump _playerJump;
    [SerializeField] private PlayerMover _playerMovement;
    [SerializeField] private PlayerAnimation _playerAnimation;

    [SerializeField] private float _jumpForce;
    [SerializeField] private float _movementSpeed;

    private void Update()
    {
        UserInputWalk(KeyCode.A, KeyCode.D);
        UserInputJump(KeyCode.Space);

        if (_playerMovement == null || _playerAnimation == null)
            return;
    }

    private void UserInputWalk(KeyCode leftKey, KeyCode rightKey)
    {
        bool isWalking = Input.GetKey(leftKey) || Input.GetKey(rightKey);
        _playerMovement.Move(isWalking ? _movementSpeed : 0f);

        _playerAnimation.SetWalkAnimation(isWalking);
    }

    private void UserInputJump(KeyCode key)
    {
        bool isGrounded = IsGrounded();
        bool shouldJump = isGrounded && Input.GetKeyDown(key);

        if (shouldJump)
        {
            _playerJump.Jump(_jumpForce);
            _playerAnimation.SetJumpAnimation(true);
        }

        else
            _playerAnimation.SetJumpAnimation(false);
    }

    private bool IsGrounded()
    {
        float recastDistance = 0.1f;
        RaycastHit hit;

        return Physics.Raycast(transform.position, Vector3.down, out hit, recastDistance);
    }
}