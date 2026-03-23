using UnityEngine;

public class Spawner2Script : MonoBehaviour
{
    public Transform T;
    public GhostScript Ghost;
    public BulletScript BulletPrefab;
    public bullet2script Bullet2Prefab;
    
    public Bullet3Script Bullet3Prefab;  

    public float Timer = 0.0f;
    public float TimerLimit = 2.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        //Attack2();


    }
    public void Attack2()
    {
        Timer += Time.deltaTime; 

       if (Timer >= TimerLimit)
       {
           Instantiate(Bullet2Prefab,T.position + new Vector3 (0.7f,0,0),Quaternion.identity);
           Timer = 0.0f;
           T.position = new Vector3 (-5.18f, -1 ,0);
           Bullet2Prefab.speed2X = 5;
           Bullet2Prefab.speed2Y = 3;

           Instantiate(Bullet3Prefab,T.position + new Vector3 (0.7f,0,0),Quaternion.identity);
           Timer = 0.0f;
           T.position = new Vector3 (-5.18f, -1 ,0);
           Bullet3Prefab.speed3X = 5;
           Bullet3Prefab.speed3Y = -3;

           Instantiate(BulletPrefab,T.position + new Vector3 (0.7f,0,0),Quaternion.identity);
           Timer = 0.0f;
           T.position = new Vector3 (-5.18f, -1 ,0);
           BulletPrefab.speedX = 5;
        }
    }
}
