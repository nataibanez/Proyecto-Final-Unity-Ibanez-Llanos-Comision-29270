using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class BackToMainMenuHUD : MonoBehaviour
{

    public void GoBackToMainMenu()
    {
        //SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(0);
    }

    public void Testeocoso()
    {
        Debug.Log ("Probando si este cosillo funciona");
    }
}
