using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Dynamic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject subject;
    public GameObject movePlate;

    public Sprite redKingChecker;

    Checkers checkers;
    GameManager gameManager;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 position2D = new Vector2(position.x, position.y);

            RaycastHit2D hit = Physics2D.Raycast(position2D, Vector2.zero);

            if(hit.collider != null)
            {
                string name = hit.collider.gameObject.name;
                GameObject obj = GameObject.Find(name);
                gameManager.FindFreeSpaces(obj);
            }
        }
    }


}
