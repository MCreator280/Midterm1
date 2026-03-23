using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform T;
    public BulletScript BulletPrefab;
    public GhostScript Ghost;
    public bullet2script Bullet2Prefab;
    
    public float Timer = 0.0f;
    public float TimerLimit = 2.0f;
    

    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void Attack1()
    {       
        
        Timer += Time.deltaTime; 

        if (Timer >= TimerLimit)
        {
           Instantiate(BulletPrefab,T.position + new Vector3 (0.7f,0,0),Quaternion.identity);
           Timer = 0.0f;
           T.position = new Vector3 (-4.51f, Ghost.transform.position.y ,0);
           BulletPrefab.speedX = 5;
        }
    }

    
    
    
}
