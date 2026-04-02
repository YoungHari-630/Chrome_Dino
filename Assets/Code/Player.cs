using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController character;
    private Vector2 dir;

    public float gravity = 9.8f * 2f; // Rigidbody 2D와 달리 중력을 코드로 계산해서 줘야함
    public float jumpForce = 8f;
    private void Awake()
    {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable()
    {
        dir = Vector2.zero;
    }

    private void Update()
    {
        dir += Vector2.down * gravity * Time.deltaTime; //중력 적용

        if (character.isGrounded) // CharacterController의 장점 - 바닥 판정을 알아서 해준다!
        {
            dir = Vector2.down; // 아무 버튼 안 눌렀을 때 아래 방향 적용
						// Unity 내장 기능 - Jump 버튼을 설정해줄 수 있다. 기본적으로는 Space. Input System(Old)에 해당.
            if (Input.GetButtonDown("Jump")) 
            {
                dir = Vector2.up * jumpForce; // Jump 매핑된 버튼 눌렀을 때 위로 방향 * 힘 적용
            }
        }

        character.Move(dir * Time.deltaTime); // CharacterController의 장점 - 움직임 함수 존재
    }
}