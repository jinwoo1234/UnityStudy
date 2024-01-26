using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectControl : MonoBehaviour
{
    float speed = 3f;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        // GambObject의 Rigidbody2D 컴포넌트를 불러옴
        rigid = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Translate - 방향을 입력받음
        // transform.Translate(Vector2.up * speed * Time.deltaTime);

        // position 값을 직접 변경함
        // transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;

        // rigidbody 컴포넌트를 이용해 물리적 힘으로 이동
        // rigid.AddForce(transform.up * speed, ForceMode2D.Force);

        float xMove = Input.GetAxis("Horizontal"); // 수직 입럭(위, 아래키)
        float yMove = Input.GetAxis("Vertical"); // 수평 입력(좌, 우)

        // 키 입력이 없을 경우 (0,0)으로 동작 안하고 있을 경우 1이 입력됨
        // rigidbody의 속력을 변경해서 이동
        rigid.velocity = new Vector2(xMove, yMove) * speed;
        
        // 연속적인 회전
        this.transform.Rotate(new Vector3(0, 0, 30f) * Time.deltaTime);

        // 일시적 회전
        // this.transform.rotation = Quaternion.Euler(0, 0, 30f);
    }
}
