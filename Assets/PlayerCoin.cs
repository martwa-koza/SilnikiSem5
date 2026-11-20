using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{

    private int coin;
    public event Action<int> OnAddCoin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoin(int coinToAdd)
    {
        coin += coinToAdd;
        OnAddCoin?.Invoke(coin);
    }

}
