using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public GameObject gamePiece;

    public int blackLeft = 22;
    public int whiteLeft = 22;

    private GameObject[,] positions = new GameObject[9,5];
    private GameObject[] playerBlack = new GameObject[22];
    private GameObject[] playerWhite = new GameObject[22];

    private bool currentPlayerBlack = false;

    private bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        playerWhite = new GameObject[]{
            Create("white_piece", 0, 0), Create("white_piece", 1, 0), Create("white_piece", 2, 0), 
            Create("white_piece", 3, 0), Create("white_piece", 4, 0), Create("white_piece", 5, 0), 
            Create("white_piece", 6, 0), Create("white_piece", 7, 0), Create("white_piece", 8, 0), 
            Create("white_piece", 0, 1), Create("white_piece", 1, 1), Create("white_piece", 2, 1), 
            Create("white_piece", 3, 1), Create("white_piece", 4, 1), Create("white_piece", 5, 1), 
            Create("white_piece", 6, 1), Create("white_piece", 7, 1), Create("white_piece", 8, 1), 
            Create("white_piece", 1, 2), Create("white_piece", 3, 2), Create("white_piece", 6, 2), 
            Create("white_piece", 8, 2)
        };
        playerBlack = new GameObject[]{
            Create("black_piece", 0, 2), Create("black_piece", 2, 2), Create("black_piece", 5, 2), 
            Create("black_piece", 7, 2), 
            Create("black_piece", 0, 3), Create("black_piece", 1, 3), Create("black_piece", 2, 3), 
            Create("black_piece", 3, 3), Create("black_piece", 4, 3), Create("black_piece", 5, 3), 
            Create("black_piece", 6, 3), Create("black_piece", 7, 3), Create("black_piece", 8, 3), 
            Create("black_piece", 0, 4), Create("black_piece", 1, 4), Create("black_piece", 2, 4), 
            Create("black_piece", 3, 4), Create("black_piece", 4, 4), Create("black_piece", 5, 4), 
            Create("black_piece", 6, 4), Create("black_piece", 7, 4), Create("black_piece", 8, 4), 
        };


        for(int i = 0; i < playerWhite.Length; i++){
            SetPosition(playerWhite[i]);
            SetPosition(playerBlack[i]);
        }
    }

    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(gamePiece, new Vector3(0, 0, -1), Quaternion.identity);
        Fanoman fm = obj.GetComponent<Fanoman>();
        fm.name = name;
        fm.SetXBoard(x);
        fm.SetYBoard(y);
        fm.Activate();
        return obj;
    }

    public void SetPosition(GameObject obj)
    {
        Fanoman fm = obj.GetComponent<Fanoman>();
        positions[fm.GetXBoard(), fm.GetYBoard()] = obj;
    }

    public void SetPositionEmpty(int x, int y)
    {
        positions[x, y] = null;
    }

    public GameObject GetPosition(int x, int y)
    {
        return positions[x, y];
    }

    public bool PositionOnBoard(int x, int y)
    {
        if (x < 0 || y < 0 || x >= positions.GetLength(0) || y >= positions.GetLength(1)) return false;
        return true;
    }

    public bool GetCurrentPlayerBlack(){
        return currentPlayerBlack;
    }

    public bool IsGameOver(){
        return gameOver;
    }

    public void GameOverCommand(){
        gameOver = true;
    }

    public void NextTurn(){
        currentPlayerBlack = !currentPlayerBlack;
    }

    public void Update(){
        if (gameOver && Input.GetMouseButtonDown(0)){
            gameOver = false;

            SceneManager.LoadScene("MainScene");
        }
    }

}
