using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public float dropSpeed = -0.001f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody Item = GetComponent<Rigidbody>();
        Item.AddTorque(50f, 30f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, this.dropSpeed , 0);
        if (transform.position.y < -0.3f)
        {
            Destroy(gameObject);
        }
    }
}
