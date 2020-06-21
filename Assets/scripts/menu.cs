using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void menuclick(){
        SceneManager.LoadScene(1);
    }
    public void quit_app(){
        Application.Quit();
    }
}
