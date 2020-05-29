using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RewardMoney : MonoBehaviour
{
    static Text text;
    public static string rewardText;

    void Start()
    {
        text = GetComponent<Text>();

    
        
    }
    private void Update()
    {
        text.text = "" + rewardText;
    }
    public static void ShowReward(int reward)
    {
        rewardText = "" + reward;
    }

}
