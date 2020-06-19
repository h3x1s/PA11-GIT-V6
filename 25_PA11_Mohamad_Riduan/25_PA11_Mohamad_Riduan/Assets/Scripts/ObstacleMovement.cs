using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;
    private int Score;
    public Text txtScore;
  
    // Start is called before the first frame update
    void Start()
    {
        txtScore = GetComponent<Text>();
        
        txtScore.text = "Score:" + Score;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.y < -5)
        {
            txtScore.text = "Score:" + Score;
            Destroy(this.gameObject);
            
            Score++;
            
        }
    }
}
