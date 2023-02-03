using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MONEY : MonoBehaviour {


    public int money;
    public TextMeshProUGUI moneyText;
    [SerializeField] private int amount = 1;

    public static MONEY instance;

    private void Start()
    {
        moneyText.text = "$" + money.ToString();
        
    }

    void Awake() {
        instance = this;
    }

    public void AddMoney() {
        money += amount;
        moneyText.text = "$" + money.ToString();
    }
    public void TakeMoney(int amount) {
        money -= amount;
        moneyText.text = "$" + money.ToString();
    }

}
