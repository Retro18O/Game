using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
    public double Wood;
    public double Metal;
    public double Rock;
    public double Food;
    public double woodIncrement = 0;
    public double metalIncrement = 0;
    public double rockIncrement = 0;
    public double foodIncrement = 0;

    public Text WoodText;
    public Text MetalText;
    public Text RockText;
    public Text FoodText;

    private void Start()
    {
        Wood = PlayerPrefs.GetInt("wood");
        Metal = PlayerPrefs.GetInt("metal");
        Rock = PlayerPrefs.GetInt("rock");
        Food = PlayerPrefs.GetInt("food");
        CalculateOfflainIncome();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("LastPlayedTime", DateTime.UtcNow.ToString());
    }
    private void CalculateOfflainIncome()
    {
        string LastPlayedTimeString = PlayerPrefs.GetString("LastPlayedTime", null);
        if (LastPlayedTimeString == null)
        {
            return;
        }
        var LastPlayedTime = DateTime.Parse(LastPlayedTimeString);
        int AutoEarnTimeLimit = 10800; //3 * 60 * 60
        double TimeSpan = (DateTime.UtcNow - LastPlayedTime).TotalSeconds;
        if (TimeSpan > AutoEarnTimeLimit)
        {
            TimeSpan = AutoEarnTimeLimit;
        }
        Wood += woodIncrement * (TimeSpan / 3600);
        Metal += metalIncrement * (TimeSpan / 3600);
        Rock += rockIncrement * (TimeSpan / 3600);
        Food += foodIncrement * (TimeSpan / 3600);

    }


    public void ToShop()
    {
        SceneManager.LoadScene(1);
    }

    void Update()
    {
        WoodText.text = Wood.ToString();
        MetalText.text = Metal.ToString();
        RockText.text = Rock.ToString();
        FoodText.text = Food.ToString();
    }
}
