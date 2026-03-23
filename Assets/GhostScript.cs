using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GhostScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D RB;

    public SpriteRenderer SR;

    public float Speed = 5;
    
    public float Timer = 0f;

    public TextMeshPro Text;
    public int Health = 5;

    void Start()
    {
        
    }

    void Update()
    {

        Text.text = "Health: " + Health;
        
        Vector2 vel = new Vector2 (0,0);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
        }
         else if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }

         if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
         else if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }

        RB.linearVelocity = vel;

        
        Timer -= Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Timer = 0.5f;
        }

        if (Timer > 0)
        {
            transform.localScale = new Vector3 (0.5f,0.5f,0.5f);
        }
        else
        {
            transform.localScale = new Vector3 (0.27f, 0.27f, 0.27f);
        }

        if (Health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Debug.Log("You're Dead");
        }

    }   

     private void OnCollisionEnter2D(Collision2D other)
    {
         BulletScript bs = other.gameObject.GetComponent<BulletScript>();

          if (bs != null)
            {
             Health --;
            }
        
    }




}




