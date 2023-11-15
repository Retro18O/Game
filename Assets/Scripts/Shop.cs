using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;
using System;
using UnityEngine.UI;



public class Shop : MonoBehaviour
{
    public double Wood;
    public double Metal;
    public double Rock;
    public double Food;

    public Text WoodText;
    public Text MetalText;
    public Text RockText;
    public Text FoodText;

    // Start is called before the first frame update
    void Start()
    {
        Wood = PlayerPrefs.GetInt("wood");
        Metal = PlayerPrefs.GetInt("metal");
        Rock = PlayerPrefs.GetInt("rock");
        Food = PlayerPrefs.GetInt("food");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
