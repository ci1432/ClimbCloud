using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator; //애니메이션을 제어하기 위해서.
    float jumpForce = 680.0f;

    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //점프
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.linearVelocity.y == 0)
        {
            animator.SetTrigger("Jump");
            rigid2D.AddForce(transform.up * jumpForce);
        }

        //좌우 이동
        int key = 0;
        /* if (Input.GetKey(KeyCode.RightArrow))
        { 
            key = 1;
            transform.localScale = new Vector3(key, transform.localScale.y, transform.localScale.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            key = -1;
            transform.localScale = new Vector3(key, transform.localScale.y, transform.localScale.z);
        }
        */

        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;


        //움직이는 방향에 따라 반전한다
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //플레이어 속도
        float speedx = Mathf.Abs(rigid2D.linearVelocity.x);

        //스피드 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        animator.speed = speedx / 2.0f;

        if (transform.position.y < -8f)
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    //골 도착

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("골인!!");
        SceneManager.LoadScene("ClearScene");
    }
}
