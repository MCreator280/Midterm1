using UnityEngine;
using TMPro;

public class BossScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public int Health = 3;
    
    public float Timer = 0.0f;
    
    public int Generator = 0;
    public TextMeshPro Text;

    public SpawnerScript S1;
    public Spawner2Script S2;



    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //  Text.text = "Boss: " + Health;

        // int ranGen = Random.Range(1,3);

        // Timer += Time.deltaTime;

        // if (Timer >= 5)
        // {
        //     Debug.Log(Generator = ranGen);
        //     Timer = 0;
        // }
        

        if (S2 != null && Generator == 2)
        {
            S2.Attack2();
            S1.T.position = new Vector3 (-2.58f,7.11f,0);
        }

        if (S1 != null && Generator == 1)
        {
            S1.Attack1();
            S2.T.position = new Vector3 (-6.08f,7.11f,0);
        }

    }

    
}
