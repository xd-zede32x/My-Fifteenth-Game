using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerRotation : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private void Start()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    public void MoveAndSetAnimations(float rotationY, PlayerAnimations animations, bool isRunning, float speed)
    {
        transform.rotation = Quaternion.Euler(0f, rotationY, 0f);

        if (isRunning)
            animations.SetAnimations(PlayerAnimationType.Run, true);

        else
            animations.SetAnimations(PlayerAnimationType.Walk, true);

        _playerMovement.Move(speed);
    }
}