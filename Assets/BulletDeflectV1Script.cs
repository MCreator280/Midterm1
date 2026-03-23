using UnityEngine;

public class BulletDeflectV1Script : MonoBehaviour
{
    public GhostScript Ghost;
    public BossScript Boss;
    public Rigidbody2D RB; 

    public float speedX = 0;
    public float speedY = 0;

    public float Timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vel = new Vector2(0,0);
        vel.x = speedX;
        vel.y = speedY;
        RB.linearVelocity = vel;
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 9)
        {
            transform.position = new Vector3 (0,0,0);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
         if (other.gameObject.name == "Ghost" && other.transform.localScale.x >= 0.45f)
        {
            Destroy(gameObject);
            Boss.Health --;
        }

    }
}

