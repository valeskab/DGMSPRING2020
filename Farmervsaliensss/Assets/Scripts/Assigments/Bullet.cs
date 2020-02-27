using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   private int damage = 1;
    public int time = 5;
    
    void Start()
    {
        //StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var hit = other.gameObject;
            var health = hit.GetComponent<EnemyHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
                Debug.Log("Ouch, you hit me!");
            }
        }

    }

    int Calc(int num1, int num2)
    {
        int total;

        total = num
    }



    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
    }
}
