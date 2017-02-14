using UnityEngine;
using System.Collections;

public class BossHit : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "enemy")
            Destroy(this.gameObject);
    }
}
