using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerAnimation))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    private PlayerAnimation _playerAnimation;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _playerMovement.Move(-_speed);
            _playerAnimation.PlayerWalk();
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerMovement.Move(-_speed);
            _playerAnimation.PlayerWalk();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerMovement.Jump(_jumpForce);
            _playerAnimation.PlayerJump();
        }
    }
}