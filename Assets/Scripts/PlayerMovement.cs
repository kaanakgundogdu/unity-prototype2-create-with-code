using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float deadLine = 10.95f;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -deadLine)
        {
            transform.position= new Vector3 (-deadLine , transform.position.y, transform.position.z);
        }

        else if (transform.position.x > deadLine)
        {
            transform.position= new Vector3 (deadLine , transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) //down basıldığında up olursa tuştan el çekildiğinde işlemi yapıyor.
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); //Instantiate var olan objeyi bidaha oluşturyor kopyalıyor yani
            
        }



    }
}
