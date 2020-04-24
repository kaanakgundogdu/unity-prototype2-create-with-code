using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Counter : MonoBehaviour
{
    float currentTime = 0f;
    int startingTime = 60;
    public Text counter;
    public GameObject kaan;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime > 0f)
        {
            currentTime -= 1 * Time.deltaTime;

            counter.text = ((int)currentTime).ToString();
        }

        else if(currentTime<=0f)
        {

            kaan.gameObject.SetActive(true);
            Time.timeScale = 0;

        }

    }
}
