using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    float distance = 8;

    void OnMouseDrag()
    {
        if (this.gameObject.name != "whiteChecker")
        {
            Vector3 mouseposition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mouseposition);
            transform.position = objPosition;
        }
    }
}