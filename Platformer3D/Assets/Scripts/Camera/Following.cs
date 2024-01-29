using UnityEngine;

public class Following : MonoBehaviour
{
    [SerializeField] private Transform _target, _selfTransform;

    private void LateUpdate()
    {
        _selfTransform.position = Vector3.Lerp(_selfTransform.position, _target.position + new Vector3(4, 2.5f, -7.22f), 0.5f);
    }
}