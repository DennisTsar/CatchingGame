using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    int xbound;
    int zbound;
    public int score;
    TMP_Text txt;
    void Start()
    {
        txt = GameObject.Find("Text").GetComponent<TMP_Text>();
        score = 0;
        xbound = 6;
        zbound = 4;
        txt.text = "Score:" + score;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.z < zbound)
            transform.Translate(Vector3.forward * 0.1f);
        if (Input.GetKey(KeyCode.S) && transform.position.z > -zbound)
            transform.Translate(Vector3.back * 0.1f);
        if (Input.GetKey(KeyCode.D) && transform.position.x < xbound)
            transform.Translate(Vector3.right * 0.1f);
        if (Input.GetKey(KeyCode.A) && transform.position.x > -xbound)
            transform.Translate(Vector3.left * 0.1f);
    }
    public void AddScore()
    {
        score++;
        txt.text = "Score: " + score;
    }
}

