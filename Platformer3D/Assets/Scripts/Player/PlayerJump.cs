using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public void Jump(Rigidbody rigidbody, float jumpForce)
    {
        rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}