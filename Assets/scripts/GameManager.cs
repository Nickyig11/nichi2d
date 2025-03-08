using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public TileBoard board;
    public CanvasGroup gameOver;
    public CanvasGroup gameStart;
    public CanvasGroup gameWin;
    public int targetScore;

    private void Start()
    {
    // StartGame();
    }

    public void StartGame() {
        Debug.Log("se lanza el juego");
        gameStart.alpha = 1f;
        gameStart.interactable = true;
        gameStart.blocksRaycasts = true; 
        Time.timeScale = 0;
        StartCoroutine(Fade(gameStart, 1f, 1f));
    }

    public void ResetGameStart()
    {
        Debug.Log("se vuelve a lanzar el juego");
        gameStart.alpha = 1f;
        gameStart.interactable = true;
        gameStart.blocksRaycasts = true;
        Time.timeScale = 0;
    }
    public void StartGameWithDifficulty(int difficulty)
    {
        

        targetScore = difficulty;
        Debug.Log("Empezando juego con dificultad: " + difficulty);
        NewGame();

        gameStart.alpha = 0f;
        gameStart.interactable = false;
        gameStart.blocksRaycasts = false;

        Time.timeScale = 1;
    }
    public void NewGame()
    {
        gameOver.alpha = 0f;
        gameOver.interactable = false;
        gameWin.alpha = 0f; 
        gameWin.interactable = false;

        board.ClearBoard();
        board.CreateTile();
        board.CreateTile();
        board.CreateTile();
        board.enabled = true;
    }

    public void GameOver()
    {
    board.enabled = false;
    gameOver.interactable = true;
    gameOver.blocksRaycasts = true; 

    gameStart.interactable = false;  
    gameStart.blocksRaycasts = false;
    gameWin.interactable = false;    
    gameWin.blocksRaycasts = false;

        StartCoroutine(Fade(gameOver, 1f, 1f));
    }

    public void GameWin()
    {
        board.enabled = false;
        gameWin.interactable = true;

        StartCoroutine(Fade(gameWin, 1f, 1f));
    }

    private IEnumerator Fade(CanvasGroup canvasGroup, float to, float delay)
    {
        yield return new WaitForSeconds(delay);

        float elapsed = 0f;
        float duration = 0.5f;
        float from = canvasGroup.alpha;

        while (elapsed < duration)
        {
            canvasGroup.alpha = Mathf.Lerp(from, to, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        canvasGroup.alpha = to;
    }
}