using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collum : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<AerialAssualtTrooper> () != null)
        {
            GameControl.Instance.BirdScored();
        }
           

        
        
    }
}
