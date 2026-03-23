using UnityEngine;

public class BulletDeflectSpawnerScript : MonoBehaviour
{
    public Transform T;
    public GhostScript Ghost;

    public BulletDeflectV1Script BDPrefab;

    public float Timer = 0.0f;
    public float TimerLimit = 0.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //     DeflectBullet();
    }

    // public void DeflectBullet()
    // {
    //     // Timer += Time.deltaTime;
    //     // float ranX =  Random.Range(-2.67f,2.51f);

    //     // if (Timer >= TimerLimit)
    //     // {
    //     //    Instantiate(BDPrefab,T.position + new Vector3 (0,0.7f,0),Quaternion.identity);
    //     //    Timer = 0.0f;
    //     //    T.position = new Vector3 (ranX, 7.34f ,0);
    //     //    BDPrefab.speedY = -5;
    //     // }

    // }

}

