using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        rigid.velocity = new Vector2(xMove, yMove) * speed;

    }

    //충돌이 일어나는 순간 실행
    private void OnCollisionEnter2D(Collision2D collision) {
        
    }

    //충돌이 유지되는동안 매 프레임 실행
    private void OnCollisionStay2D(Collision2D aa) {
        if (aa.gameObject.tag == "Wall")
        {
            Debug.Log("충돌!");
        }
    }

    //충돌이 종료되는 순간 1회 호출
    private void OnCollisionExit2D(Collision2D collision) {

    }

    //물리 작용 없이 이벤트 적용
    private void OnTriggerEnter2D(Collider2D collision) {
        
    }

    private void OnTriggerStay2D(Collider2D collision) {
        
    }

    private void OnTriggerExit2D(Collider2D collision) {
if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("충돌!");
        }
    }
}
