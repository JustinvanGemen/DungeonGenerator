using UnityEngine;

public class TargetFollow : MonoBehaviour
{

    [SerializeField]private Transform _target;

    private Vector3 _transformationOffset;

    private void Start()
    {
        _transformationOffset = transform.position - _target.position;

    }


    private void LateUpdate()
    {
        transform.position = _target.position + _transformationOffset;
        transform.rotation = _target.rotation;
    }
}
