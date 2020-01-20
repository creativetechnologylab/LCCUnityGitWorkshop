using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingTree : MonoBehaviour
{
    public GameObject tree;
    GameObject treeInsta;
    float resetTime;
    float maxTime;
    bool canGen = true;
    void Start()
    {
        tree = this.gameObject;
        resetTime = Random.Range(3, 5);
        maxTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (canGen == true)
        {
            resetTime -= Time.fixedDeltaTime;
            if (resetTime <= 0)
            {
                resetTime = Random.Range(3, maxTime);
                treeInsta = Instantiate(tree);
                treeInsta.transform.localScale = new Vector3(transform.localScale.x * 0.75f, transform.localScale.y * 0.75f, transform.localScale.z * 0.75f);
                treeInsta.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), Random.Range(0, 35));
                treeInsta.transform.position += new Vector3(transform.localScale.x * Random.Range(0, 1), transform.localScale.y / Random.Range(0.3f, 1), transform.localScale.x * Random.Range(0, 1));
                maxTime += 3;


            }

            if (maxTime >= 10)
            {
                resetTime = 100;
                canGen = false;
            }
        }
        if (this.name == "SS Tree(Clone)(Clone)(Clone)(Clone)(Clone)(Clone)")
            
        {
            canGen = false;
        }
    }
}
