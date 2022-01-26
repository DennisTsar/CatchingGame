using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        //a.transform.localScale = Vector3.one;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Platform")
            collision.gameObject.GetComponent<Mover>().AddScore();
        Destroy(gameObject);
    }
}
