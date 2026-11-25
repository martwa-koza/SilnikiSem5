using TMPro;
using UnityEngine;

public class UI_StaticPanel : MonoBehaviour
{

    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;

    public PlayerCoin playerCoin;
    public TextMeshProUGUI coinText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    private void Awake()
    {
        playerHealth.OnAddHealth += PlayerHealth_OnAddHealth;
        playerHealth.OnHealthInnit += PlayerHealth_OnHealthInnit;
        playerCoin.OnCoinInnit += PlayerCoin_OnCoinInnit;
        playerCoin.OnAddCoin += PlayerCoin_OnAddCoin;
    }

    private void PlayerHealth_OnHealthInnit(int health)
    {
        ModifyHealthText(health);
    }

    private void PlayerHealth_OnAddHealth(int health)
    {
        ModifyHealthText(health);
    }

    private void ModifyHealthText(int obj)
    {
        coinText.text = "Health: " + obj.ToString();
    }

    private void PlayerCoin_OnAddCoin(int coin)
    {
        ModifyCoinText(coin);
    }

    private void PlayerCoin_OnCoinInnit(int coin)
    {
        ModifyCoinText(coin);
    }

    private void ModifyCoinText(int obj)
    {
        coinText.text = "Coins: " + obj.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
