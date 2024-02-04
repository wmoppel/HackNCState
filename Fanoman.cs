using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Fanoman : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject controller;
    public GameObject movePlate;


    private int xBoard = -1;
    private int yBoard = -1;

    private bool pieceBlack;

    private int plateDirX;
    private int plateDirY;


    public Sprite black_piece, white_piece;
    
    public void Activate(){
        controller = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();

        switch(this.name){
            case "black_piece": this.GetComponent<SpriteRenderer>().sprite = black_piece; pieceBlack = true; break;
            case "white_piece": this.GetComponent<SpriteRenderer>().sprite = white_piece; pieceBlack = false; break;
        }
    }

    public void SetCoords(){
        float x = xBoard;
        float y = yBoard;

        x *= 2f;
        y *= 2f;

        x += -8f;
        y += -4f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x){
        xBoard = x;
    }

    public void SetYBoard(int y){
        yBoard = y;
    }

    private void OnMouseUp(){
        if (!controller.GetComponent<Game>().IsGameOver() && controller.GetComponent<Game>().GetCurrentPlayerBlack() == pieceBlack){
            DestroyMovePlates();
            InitiateMovePlates();
        }
        
    }

    public void DestroyMovePlates(){
        GameObject[] movePlates = GameObject.FindGameObjectsWithTag("MovePlate");
        for (int i = 0; i < movePlates.Length; i++){
            Destroy(movePlates[i]);
        }
    }

    public void InitiateMovePlates(){
        SurroundMovePlate();
    }

    public void SurroundMovePlate(){
        if(Math.Abs(xBoard)%2 == Math.Abs(yBoard)%2){
            PointMovePlate(xBoard - 1, yBoard + 1, -1, 1);
            PointMovePlate(xBoard, yBoard + 1, 0, 1);
            PointMovePlate(xBoard + 1, yBoard + 1, 1, 1);
            PointMovePlate(xBoard - 1, yBoard, -1, 0);
            PointMovePlate(xBoard + 1, yBoard, 1, 0);
            PointMovePlate(xBoard - 1, yBoard - 1, -1, -1);
            PointMovePlate(xBoard, yBoard - 1, 0, -1);
            PointMovePlate(xBoard + 1, yBoard - 1, 1, -1);
        } else{
            PointMovePlate(xBoard, yBoard + 1, 0, 1);
            PointMovePlate(xBoard - 1, yBoard, -1, 0);
            PointMovePlate(xBoard + 1, yBoard, 1, 0);
            PointMovePlate(xBoard, yBoard - 1, 0, -1);
        }
        
    }

    public void PointMovePlate(int x, int y, int dirx, int diry){
        Game sc = controller.GetComponent<Game>();
        if (sc.PositionOnBoard(x, y)){
            GameObject cp = sc.GetPosition(x, y);

            plateDirX = dirx;
            plateDirY = diry;

            if (cp == null){
                MovePlateSpawn(x, y, dirx, diry);
            }
            // else if (cp.GetComponent<Fanoman>().pieceBlack != pieceBlack){
            //     MovePlateAttackSpawn(x, y);

            // }
        }
    }

    public void MovePlateSpawn(int MatrixX, int MatrixY, int dirx, int diry){
        float x = MatrixX;
        float y = MatrixY;
        // bool clear = true;
        
        x *= 2f;
        y *= 2f;

        x += -8f;
        y += -4f;

        GameObject mp = Instantiate(movePlate, new Vector3(x, y, -3.0f), Quaternion.identity);

        MovePlate mpScript = mp.GetComponent<MovePlate>();
        mpScript.SetReference(gameObject);
        mpScript.SetCoords(MatrixX, MatrixY);
        mpScript.dirx = dirx;
        mpScript.diry = diry;

        // while (clear){
            // Game sc = controller.GetComponent<Game>();
            // if (sc.PositionOnBoard(xBoard + (plateDirX * 1), yBoard + (plateDirY * 1))){
                // GameObject fp = sc.GetPosition(xBoard + (plateDirX * 1), yBoard + (plateDirY * 1));
                // GameObject fp = sc.GetPosition(0, 0);

                // if (fp == null){
                    // clear = false;
                // } else if (fp.GetComponent<Fanoman>().IsPieceBlack() == controller.GetComponent<Game>().GetCurrentPlayerBlack())
                // {
                //     clear = false;
                // }
                // else
                // {
                //     Destroy(fp);
                // }
            // }
        // }
    }

    // public void MovePlateAttackSpawn(int MatrixX, int MatrixY){
    //     float x = MatrixX;
    //     float y = MatrixY;
        
    //     x *= 2f;
    //     y *= 2f;

    //     x += -8f;
    //     y += -4f;

    //     GameObject mp = Instantiate(movePlate, new Vector3(x, y, -3.0f), Quaternion.identity);

    //     MovePlate mpScript = mp.GetComponent<MovePlate>();
    //     mpScript.attack = true;
    //     mpScript.SetReference(gameObject);
    //     mpScript.SetCoords(MatrixX, MatrixY);
    // }

    public bool IsPieceBlack(){
        return pieceBlack;
    }
}
