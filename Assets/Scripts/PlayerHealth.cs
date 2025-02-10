using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    [Header("Object References")]
    //Used for accessing the Image component on the canvas which displays the sprite
    [SerializeField] private Image display;

    [Header("Sprites")]
    //Stores all the sprites used for the health ui
    [SerializeField] private Sprite[] sprites;


    //This stuff is hidden from the designers (felix)

    //Stores how much health the player is on
    private int health = 5;


    // Start is called before the first frame update
    void Start()
    {
        UpdateDisplay();
    }

    private void Update()
    {
        //TEMP TESTING STUFF
        //decreases health on P
        if(Input.GetKeyDown(KeyCode.P))
        {
            DecreaseHealth();
        }
    }

    //Decreases the player health by 1
    public void DecreaseHealth()
    {
        Debug.Log("the players health has decreased");
        health = health - 1;

        //checks if player is dead
        if(health <= 0)
        {
            GameOver();
        }
        else
        {
            UpdateDisplay();
        }
        
    }

    //Updates the health ui sprite to reflect current health
    private void UpdateDisplay()
    {
        display.sprite = sprites[health-1];
    }

    private void GameOver()
    {
        Debug.Log("the player is dead");
    }
}
