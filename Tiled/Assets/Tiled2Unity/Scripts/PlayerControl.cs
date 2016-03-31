using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float Speed = 5.0f;
    Animator animator;
    bool walk;
    // Use this for initialization
    void Start () {
        animator = this.GetComponent<Animator>();
	}
    // Update is called once per frame
    void Update () {
        
        if (Input.GetKey(KeyCode.A))
        {
            walk = true;
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            walk = true;
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            walk = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            walk = true;
        }
        else
            walk = false;
        animator.SetBool("walk", walk);
        GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * Speed, 0.8f),Mathf.Lerp(0, Input.GetAxis("Vertical") * Speed, 0.8f));
        
    }
}
