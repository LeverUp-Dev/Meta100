using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regacy : MonoBehaviour
{
    Animation anim;
    public float speed = 1;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float r = Input.GetAxis("Mouse X");
        Vector3 mv = Vector3.right * x + Vector3.forward * z;
        transform.Translate(mv.normalized * speed * Time.deltaTime);
        transform.Rotate(0, r * speed, 0);
        if (x != 0 || z != 0) {
            anim.CrossFade("WalkF", 0.25f);
        }
        else {
            anim.CrossFade("Idle", 0.25f);
        }
    }
}
