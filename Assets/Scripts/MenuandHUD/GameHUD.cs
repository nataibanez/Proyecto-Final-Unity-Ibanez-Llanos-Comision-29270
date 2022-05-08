using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    private bool isPauseActive = false;
    public Text scoreNumber;
    public GameObject MenuPausa;
    
    void Start()
    {
        MenuPausa.SetActive(false);
    }
    void Update()
    {
        GamePauseToggle();
    }

    void GamePauseToggle()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPauseActive == true)
            {
                GameUnpause();
            }
            else
            {
                GamePause();
            }
        }
    }
    void GamePause()
    {
        MenuPausa.SetActive(true);
        isPauseActive = true;
        Time.timeScale = 0;
    }

    void GameUnpause()
    {
        MenuPausa.SetActive(false);
        isPauseActive = false; 
        Time.timeScale = 1;
    }


}
