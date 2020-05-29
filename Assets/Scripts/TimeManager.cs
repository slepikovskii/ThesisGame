using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float startingTime;

    public bool isTimeUp;
    public GameObject rewardSystem;

    private Text theText;
    // Start is called before the first frame update
    void Start()
    {
        theText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        startingTime -= Time.deltaTime;
        theText.text = "" + Mathf.Round(startingTime);

        if(startingTime <= 0)
        {
            isTimeUp = true;
            Time.timeScale = 0f;
            rewardSystem.SetActive(true);
        }
        else
        {
            isTimeUp = false;
            Time.timeScale = 1f;
            rewardSystem.SetActive(false);
        }

       
    }


}
