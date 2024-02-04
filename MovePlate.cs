using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePlate : MonoBehaviour
{
    public GameObject controller;

    GameObject reference = null;

    int MatrixX;
    int MatrixY;

    public int dirx;
    public int diry;

    public bool attack = false;

    public void Start(){
        if(attack){
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }

    public void OnMouseUp(){
        controller = GameObject.FindGameObjectWithTag("GameController");
        

        // if(attack){
        //     GameObject fp = controller.GetComponent<Game>().GetPosition(MatrixX, MatrixY);

        //     // GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        //     // for (int i = 0; i < players.Length; i++){
        //     //     if (players[i].GetComponent<Fanoman>.IsPieceBlack() == controller.GetComponent<Game>.GetCurrentPlayerBlack()){

        //     //     }
        //     // }


        //     Destroy(fp);
        // }
        Game sc = controller.GetComponent<Game>();
        
        if ((MatrixX + (dirx) >= 0 && MatrixY + (diry) >= 0 && MatrixX + (dirx) < 9 && MatrixY + (diry) < 5) &&
         (MatrixX + (dirx * -2) >= 0 && MatrixY + (diry * -2) >= 0 && MatrixX + (dirx * -2) < 9 && MatrixY + (diry * -2) < 5))
        {
            GameObject gp = sc.GetPosition(MatrixX + (dirx), MatrixY + (diry));
            GameObject tp = sc.GetPosition(MatrixX + (dirx * -2), MatrixY + (diry * -2));
            if (gp != null && gp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack() && tp != null && tp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack())
            {
                int i = 1;
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                        i++;
                    }
                }
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                        i++;
                    }
                }
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                    }
                }

            } else{
                int i = 1;

                
                // while(i < 4){
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                        i++;
                    }
                }
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                        i++;
                    }
                }
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                    }
                }
                
                i = -2;

                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                        i--;
                    }
                }
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                        i--;
                    }
                }
                if (MatrixX + (dirx * i) >= 0 && MatrixY + (diry * i) >= 0 && MatrixX + (dirx * i) < 9 && MatrixY + (diry * i) < 5){
                    GameObject fp = sc.GetPosition(MatrixX + (dirx * i), MatrixY + (diry * i));
                    if (fp != null && fp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
                        Destroy(fp);
                        if (fp.GetComponent<Fanoman>().IsPieceBlack())
                        {
                            sc.GetComponent<Game>().blackLeft--;
                        } else{
                            sc.GetComponent<Game>().whiteLeft--;
                        }
                    }
                }
            }
        }
        
        // }

        if(sc.GetComponent<Game>().whiteLeft == 0 || sc.GetComponent<Game>().blackLeft == 0){
            sc.GetComponent<Game>().GameOverCommand();
        }
        



        

        controller.GetComponent<Game>().SetPositionEmpty(reference.GetComponent<Fanoman>().GetXBoard(),
             reference.GetComponent<Fanoman>().GetYBoard());
        
        reference.GetComponent<Fanoman>().SetXBoard(MatrixX);
        reference.GetComponent<Fanoman>().SetYBoard(MatrixY);
        reference.GetComponent<Fanoman>().SetCoords();

        controller.GetComponent<Game>().SetPosition(reference);

        // bool found = false;
        // // for (int bx = -1; bx < 2; bx++){
        // //     for (int by = -1; by < 2; by++){
        // //         while(!found){
                    
        // //         }
        // //     }
        // // }
        // int bx = -1;
        // int by = -1;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = 0;
        // by = -1;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = 1;
        // by = -1;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = -1;
        // by = 0;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = 1;
        // by = 0;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = -1;
        // by = 1;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = 0;
        // by = 1;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // bx = 1;
        // by = 1;
        // if (MatrixX + bx >= 0 && MatrixY + by >= 0 && MatrixX + bx < 9 && MatrixY + by < 5){
        //     GameObject fp = sc.GetPosition(MatrixX + bx, MatrixY + by);
        //     if (fp == null){
        //         if (MatrixX + (bx * 2) >= 0 && MatrixY + (by * 2) >= 0 && MatrixX + (bx * 2) < 9 && MatrixY + (by * 2) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * 2), MatrixY + (by * 2));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //         if (MatrixX + (bx * -1) >= 0 && MatrixY + (by * -1) >= 0 && MatrixX + (bx * -1) < 9 && MatrixY + (by * -1) < 5){
        //             GameObject qp = sc.GetPosition(MatrixX + (bx * -1), MatrixY + (by * -1));
        //             if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //                 found = true;
        //             }
        //         }
        //     }
        // }

        // if (found == false)
        // {
        // }

        bool found = false;
        // if (MatrixX + 1 >= 0 && MatrixY + 1 >= 0 && MatrixX + 1 < 9 && MatrixY + 1 < 5){
        //     GameObject qp = sc.GetPosition(MatrixX + 1, MatrixY + 1);
        //     if (qp != null && qp.GetComponent<Fanoman>().IsPieceBlack() != sc.GetCurrentPlayerBlack()){
        //         found = true;
        //     }
        // }
        if(!found){
            controller.GetComponent<Game>().NextTurn();
        }
        



        reference.GetComponent<Fanoman>().DestroyMovePlates();
    }

    public void SetCoords(int x, int y){
        MatrixX = x;
        MatrixY = y;
    }

    public void SetReference(GameObject obj){
        reference = obj;
    }

    public GameObject GetReference(){
        return reference;
    }
}
