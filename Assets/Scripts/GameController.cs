using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public static int Points { get; private set; }

    public static bool GameStarted {get; private set; }

    [SerializeField]
    private TextMeshProUGUI gameResult;
    [SerializeField]
    private TextMeshProUGUI pointsTest;

    private void Awake()
    {
        if (Instance == null)
        Instance = this;
    }


    private void Start()
    {
        StartGame();
    }



    public void StartGame()
    {
        gameResult.text = "";
        SetPoints(0);
        GameStarted = true;

        Field.Instance.GenerateField();
    }

    public void Win()
    {
        GameStarted = false;
        gameResult.text = "YOU WIN!!";
    }

    public void Lose()
    {
        GameStarted = false;
    }

    public void AddPoints(int points)
    {
        SetPoints(Points + points);
    }

    private void SetPoints(int points)
    {
        Points = points;
        pointsTest.text = Points.ToString();

    }

}
