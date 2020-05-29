using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int money;

    Text text;

    private void Start()
    {
        text = GetComponent<Text>();

        money = 0;
    }

    private void Update()
    {
        if (money < 0)
            money = 0;

        text.text = "" + money;

        RewardMoney.ShowReward(money);
    }

    public static void AddMoney(int moneyToAdd)
    {
        money += moneyToAdd;

    }

   
}
