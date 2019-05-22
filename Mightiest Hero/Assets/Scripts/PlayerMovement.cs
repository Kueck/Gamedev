using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    int atk;
    int def;
    int invulnerable;
    public float speed;
    Vector3 moveDir;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = +1f;
            anim.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
            anim.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = +1f;
            anim.SetBool("Walking", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
            anim.SetBool("Walking", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Walking", false);
        }
        moveDir = new Vector3(moveX, moveY).normalized;
        transform.position += moveDir * speed * Time.deltaTime;
        anim.SetFloat("DirectionX", moveDir.x);
        anim.SetFloat("DirectionY", moveDir.y);
        print("moveDiry:" + moveDir.y);
        print(moveDir);
    }

    void doDamage()
    {

    }

    void takeDamage()
    {

    }


}
