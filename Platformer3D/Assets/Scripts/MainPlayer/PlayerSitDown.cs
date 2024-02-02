using UnityEngine;

public class PlayerSitDown : MonoBehaviour
{
    public void InputSitDown(PlayerAnimations playerAnimation)
    {
        bool isSittingDown = Input.GetKeyDown(KeyCode.LeftControl);
        playerAnimation.SetAnimations(PlayerAnimationType.Down, isSittingDown);
    }
}