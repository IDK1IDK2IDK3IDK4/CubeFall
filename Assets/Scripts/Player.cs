using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    //Add Variables here
    public float speed = 5;
    public UnityEvent end_game;
    // Update is called once per frame
    void Update()
    {
        //Add Movement checking here
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + Vector3.left*speed*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + Vector3.right*speed*Time.deltaTime;
        }

    }

    //Add OnCollisionEnter() here
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            end_game.Invoke();
            Destroy(gameObject);
        }
    }

}
