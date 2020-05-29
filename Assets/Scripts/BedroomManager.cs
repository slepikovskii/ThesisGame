using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomManager : MonoBehaviour
{
    public string goToStreet;
    public string goToGarage;
    public string goToShop;
    public string goPiggyBanks;
    public string goMainMenu;

    

    public void toStreet()
    {
        Application.LoadLevel(goToStreet);
    }

    public void piggyBanks()
    {
        Application.LoadLevel(goPiggyBanks);
    }

    public void goToMainMenu()
    {
        Application.LoadLevel(goMainMenu);
    }
}
