using UnityEngine;
using UnityEngine.SceneManagement;

public class endtrigger : MonoBehaviour
{

    void OnTriggerEnter()
    {
        SceneManager.LoadScene(2);
    }
}
