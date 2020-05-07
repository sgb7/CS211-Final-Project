using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public GameObject checker;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //Instantiate(checker, new Vector3(0, 0, -1), Quaternion.identity);
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            if(hit.collider != null)
            {
                Instantiate(checker, new Vector3(0, 0, -1), Quaternion.identity);
            }
        }
    }
}
