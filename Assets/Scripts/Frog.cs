using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject frog;
    public Vector2 originalPos;
    public static int numLives = 0;
    public Text livesText;

    void Start()
    {
        originalPos = frog.transform.position;
        GetLives();
    }

    public void GetLives()
    {
        numLives = Menu.lives;
        livesText.text = "you have " + numLives + " live(s) left";
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        if(rb.position.x > 3 || rb.position.y < -5 || rb.position.x < -3)
        { 
            frog.transform.position = originalPos;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Car")
        {
            if (numLives == 0)
            {
                FinalScore.finalScore = Score.CurrentScore;
                Score.CurrentScore = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                frog.transform.position = originalPos;
                numLives -= 1;
                livesText.text = "you have " + numLives + " live(s) left";
            }
        }
    }
}
