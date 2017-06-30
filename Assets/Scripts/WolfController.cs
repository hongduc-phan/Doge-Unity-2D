using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfController : MonoBehaviour {

    public GameObject bom;
    public float minBomTime = 2;
    public float maxBomTime = 4;
    private float bomTime = 0;
    private float lastBomTime = 0;
    public GameObject Sheep;
    private GameObject gameController;

    // Use this for initialization
    void Start() {
        UpdateBomTime();
        Sheep = GameObject.FindGameObjectWithTag("Player");
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update() {
        if (Time.time >= lastBomTime + bomTime)
        {
            ThroughBom();
        }
    }

    void UpdateBomTime()
    {
        lastBomTime = Time.time;
        bomTime = Random.Range(minBomTime, maxBomTime + 1);
    }

    void ThroughBom()
    {
        GameObject boom =  Instantiate(bom, transform.position, Quaternion.identity) as GameObject;
        boom.GetComponent<BomController>().target = Sheep.transform.position;
        UpdateBomTime();
        gameController.GetComponent<GameController>().GetPoint();
    }
    
}
