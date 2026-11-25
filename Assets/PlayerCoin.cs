using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{

    private int collectedCoins;
    private PlayerHealth playerHealth;
    public int coinForHealthTreashold = 10;
    public event Action<int> OnAddCoin;
    public event Action<int> OnCoinInnit;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnCoinInnit?.Invoke(collectedCoins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoin(int coinToAdd)
    {
        collectedCoins += coinToAdd;
        CheckForHealth();
        OnAddCoin?.Invoke(collectedCoins);
    }

    private void CheckForHealth()
    {
        if (collectedCoins >= coinForHealthTreashold)
        {
            collectedCoins = collectedCoins - coinForHealthTreashold;
            if (playerHealth != null)
            {
                HealPlayerForCoins();
            }
            else if (TryGetComponent<PlayerHealth>(out PlayerHealth healthComponent))
            {
                playerHealth = healthComponent;
                HealPlayerForCoins();
            }
            else
                Debug.LogError("Health component is not in the same game object as Player Health");
        }
    }

    private void HealPlayerForCoins()
    {
        playerHealth.AddHealth(playerHealth.maxHealth);
    }
}
