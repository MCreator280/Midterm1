using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speedX = 0;
    public float speedY = 0;

    public GhostScript Ghost;

    void Start()
    {
        Vector2 vel = new Vector2(0,0);
        vel.x = speedX;
        vel.y = speedY;
        RB.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
         if (other.gameObject.name == "Ghost")
        {
            Destroy(gameObject); 
        }
    }
    
    void Update()
    {
    
    }
}
