using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Generator : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    public GameObject bill;
    void Start()
    {
        time = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        int score = Mathf.Clamp(GameObject.Find("Platform").GetComponent<Mover>().score, 0, 15);
        time += Time.deltaTime;
        if (time > 4 - score / 3)
        {
            Instantiate(bill, new Vector3(Random.Range(-5.5f, 5.5f), 14, Random.Range(-3.5f, 3.5f)), Quaternion.identity);
            time -= 4 - score / 6;
        }
    }
}
