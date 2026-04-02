using UnityEngine;

public class Ground : MonoBehaviour
{
    private MeshRenderer m_Renderer;

    private void Awake()
    {
        m_Renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // GameManager에서 스피드 값 받아와서 자신의 가로 길이로 나눔 -> Ground의 가로 길이가 변해도 속도 일정
        float speed = GameManager.instance.gameSpeed / transform.localScale.x;
        // MeshRenderer에서 Offset 값을 조정. Vector2.right이므로 (1,0) -> Offset X 값이 양수로 변화
        m_Renderer.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}