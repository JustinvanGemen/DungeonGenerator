using UnityEngine;

public class Connectors : MonoBehaviour {
    [SerializeField]private string[] _tags;

    public string[] Tags
    {
        get { return _tags; }
    }
    public bool IsDefault;

    private void OnDrawGizmos()
    {
        const float scale = 1.0f;

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * scale);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position - transform.right * scale);
        Gizmos.DrawLine(transform.position, transform.position + transform.right * scale);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up * scale);

        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.125f);
    }
}
