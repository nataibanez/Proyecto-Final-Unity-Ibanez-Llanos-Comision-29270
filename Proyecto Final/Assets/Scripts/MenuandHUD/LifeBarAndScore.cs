using UnityEngine;
using UnityEngine.UI;
public class LifeBarAndScore : MonoBehaviour
{
    public Image lifeBar;
    public Text scoreText;
    public float hudActualHealth;
    public static int playerScore = 0;
    public float hudMaxHealth = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        hudActualHealth = PlayerHealthAndReceiveDamage.actualHealth;
        lifeBar.fillAmount = (hudActualHealth/hudMaxHealth);
        scoreText.text = ""+ playerScore;
    }
}
