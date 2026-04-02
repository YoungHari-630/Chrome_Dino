using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {  get; private set; }

    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed {  get; private set; }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        gameSpeed = initialGameSpeed;
    }

    private void Update()
    {
        //게임 속도가 시간이 지남에 따라 조금씩 빨라짐
        gameSpeed += gameSpeedIncrease * Time.deltaTime; 
    }
}