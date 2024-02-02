using UnityEngine;

public class PlayerMainInput : MonoBehaviour
{
    [SerializeField] private PlayerSitDown _playerSitDown;
    [SerializeField] private PlayerInputJump _playerInputJump;
    [SerializeField] private PlayerAnimations _playerAnimation;
    [SerializeField] private PlayerInputMovement _playerInputMovement;

    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;
    [SerializeField] private float _jumpForce;

    private void Update()
    {
        _playerInputJump.InputJump(_playerAnimation, _jumpForce);
        _playerInputMovement.InputMovement(_playerAnimation, _walkSpeed, _runSpeed);
        _playerSitDown.InputSitDown(_playerAnimation);
    }
}