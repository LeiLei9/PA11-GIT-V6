using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player thisPlayer;
    public float speed;
    private int score = 0;
    public Text txt_score;
   
    // Start is called before the first frame update
    void Start()
    {
        thisPlayer = this;
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0, verticalInput * speed * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4, 4), 0);

    }

    public void Scores()
    {
        score++;
        txt_score.text = "Score : " + score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
          
            SceneManager.LoadScene("GameLose");
        }
    }
}
