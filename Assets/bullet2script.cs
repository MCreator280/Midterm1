using UnityEngine;

public class bullet2script : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed2X = 0;
    public float speed2Y = 0;

    public GhostScript Ghost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vel = new Vector2(0,0);
        vel.x = speed2X;
        vel.y = speed2Y;
        RB.linearVelocity = vel;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
         if (other.gameObject.name == "Ghost")
        {
            Destroy(gameObject); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
