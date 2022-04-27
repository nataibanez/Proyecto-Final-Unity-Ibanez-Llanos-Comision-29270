using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenuPrincipal : MonoBehaviour
{
public GameObject menuControles;
void Start()
{
    menuControles.SetActive(false);
}
public void Jugar()
{
    SceneManager.LoadScene(1);
}   

public void Salir()
{
    Application.Quit();
}
public void ControlsOn()
{
    menuControles.SetActive(true);
}
public void ControlsOff()
{
    menuControles.SetActive(false);
}


}
