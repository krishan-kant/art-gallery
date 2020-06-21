using UnityEngine;

public class audio_stop : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(transform.gameObject);
    }
}
