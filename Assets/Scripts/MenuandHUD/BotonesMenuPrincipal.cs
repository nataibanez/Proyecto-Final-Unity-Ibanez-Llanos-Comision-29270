using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenuPrincipal : MonoBehaviour
{
public GameObject menuControles;
public GameObject botonJugar;
public GameObject botonControles;
public GameObject botonSalir;
public GameObject logoMenu;

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
    botonJugar.SetActive(false);
    botonControles.SetActive(false);
    botonSalir.SetActive(false);
    logoMenu.SetActive(false);

}
public void ControlsOff()
{
    menuControles.SetActive(false);
    botonJugar.SetActive(true);
    botonControles.SetActive(true);
    botonSalir.SetActive(true);
    logoMenu.SetActive(true);
}


}
