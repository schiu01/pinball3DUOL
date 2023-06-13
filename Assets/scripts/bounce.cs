using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class bounce : MonoBehaviour
{
    public static int score=0;
    // Start is called before the first frame update
    float explosionBoundValue;
    float explosionBoundRadius;

    [SerializeField]
    public Text scoreboard;
    public Vector3 localScale;
    private bool objCollided = false;
    private float collideStartTime = 0;
        
    void Start()
    {
        //scoreboard = GetComponent<Text>();
        score = 0;
        localScale = transform.localScale;
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "ball")
        //{
            explosionBoundValue = Random.Range(35.0f, 55.0f);
            explosionBoundRadius = Random.Range(35.0f, 50.0f);
            collision.rigidbody.AddExplosionForce(explosionBoundValue, transform.position, explosionBoundRadius);
        score += 1;
        //scoreboard.text = score.ToString();
        objCollided = true;
        collideStartTime = Time.time;
            //Debug.Log(explosionBoundRadius);
        //}
        
    }
    private void Update()
    {
        if(objCollided)
        {
//            Debug.Log(Time.time);
 //           Debug.Log(collideStartTime);
            if (Time.time - collideStartTime < 0.5)
            {
                Vector3 vec = new Vector3(Mathf.Sin(Time.time * 20) * localScale.x, localScale.y, Mathf.Sin(Time.time * 20) * localScale.z);
                transform.localScale = vec;

            }
            else
            {
                transform.localScale = localScale;
                objCollided = false;
                    
            }
        }
    }
}
