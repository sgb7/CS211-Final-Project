﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject subject;
    public GameObject movePlate;

    Checkers checkers;
    GameManager gameManager;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if(hit.collider != null)
            {
                Instantiate(movePlate, new Vector3(0, 0, -1), Quaternion.identity);
            }
        }
    }
}