using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Dynamic;
using System.Runtime;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject movePlate;

    Checkers checkers;
    GameManager gameManager;

    void GenerateMovePlates(GameObject obj)
    {
        //gameMangager.FindFreeSpaces(obj);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 position2D = new Vector2(position.x, position.y);

            RaycastHit2D hit = Physics2D.Raycast(position2D, Vector2.zero);

            if(hit.collider != null)
            {
                /*GameObject obj = hit.collider.gameObject;
                GenerateMovePlates(obj);*/

                //Test
                Instantiate(movePlate, new Vector3(0, 0, -1), Quaternion.identity);
            }
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Destroy(GameObject.Find("MovePlate(Clone)"));
        }
    }


}
