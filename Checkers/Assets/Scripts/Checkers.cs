using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Checkers : MonoBehaviour
{
    public GameObject controller;
    // public GameObject movePlate; ???

    private int xPos = -1;
    private int yPos = -1;

    private string player;

    public Sprite redChecker, redKingChecker;
    public Sprite whiteChecker, whiteKingChecker;

    public void SetCoords()
    {
        float x = xPos;
        float y = yPos;

        x = x * 0.66f;
        y = y * 0.66f;

        x += -2.3f;
        y += -2.3f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();

        switch(this.name)
        {
            case "redChecker":
                this.GetComponent<SpriteRenderer>().sprite = redChecker;
                break;
            case "redKingChecker":
                this.GetComponent<SpriteRenderer>().sprite = redKingChecker;
                break;
            case "whiteChecker":
                this.GetComponent<SpriteRenderer>().sprite = whiteChecker;
                break;
            case "whiteKingChecker":
                this.GetComponent<SpriteRenderer>().sprite = whiteKingChecker;
                break;
        }
    }
}
