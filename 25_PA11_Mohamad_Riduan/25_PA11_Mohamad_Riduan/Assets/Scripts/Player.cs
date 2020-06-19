using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

      

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.name == "RedCube(Clone)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
            Debug.Log("Hit");
        }
        if(collision.collider.name == "GreenCube(Clone)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
        if (collision.collider.name == "BrownCube(Clone)")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
