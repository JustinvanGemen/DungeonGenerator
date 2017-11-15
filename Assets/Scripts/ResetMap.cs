using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetMap : MonoBehaviour {

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }
    
    private void Reset()
    {
        SceneManager.LoadScene (0);
    }
}
