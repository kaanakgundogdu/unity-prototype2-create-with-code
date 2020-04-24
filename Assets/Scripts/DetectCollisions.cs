using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectCollisions : MonoBehaviour
{

    public void  OnTriggerEnter(Collider other)
    {        
        // Instead of destroying the projectile when it collides with an animal
        //Destroy(other.gameObject); 

        // Just deactivate the food and destroy the animal
        other.gameObject.SetActive(false);
        Score.score += 25;
    }



}
