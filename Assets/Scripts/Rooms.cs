using UnityEngine;

public class Rooms : MonoBehaviour {
    
    
    [SerializeField]private string[] _tags;

    public string[] Tags
    {
        get { return _tags; }   
    }
    
    public Connectors[] GetExits()
    {
        return GetComponentsInChildren<Connectors>();
    }
}
