using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player1Chip;
    public GameObject Player2Chip;

    public GameObject player1Ghost;
    public GameObject player2Ghost;

    public int heightOfBoard = 6;
    public int lengthOfBoard = 7;

    public string debugStartMessage;

    public GameObject[] spawnLoc;


    GameObject fallingPiece;


    bool Player1ChipTurn = true;

    int[,] boardState;




    // Start is called before the first frame update
    void Start()
    { 
        boardState = new int[lengthOfBoard, heightOfBoard];

        player1Ghost.SetActive(false);
        player1Ghost.SetActive(false);
    }

    public void Hovercolumn(int column)
    {

        if (boardState[column, heightOfBoard - 1] == 0 &&(fallingPiece  == null|| fallingPiece.GetComponent< Rigidbody>().velocity == Vector3.zero))

            if (Player1ChipTurn)
            {
                player1Ghost.SetActive(true);
                player1Ghost.transform.position = spawnLoc[column].transform.position;
            }
            else
            {
                player2Ghost.SetActive(true);
                player2Ghost.transform.position = spawnLoc[column].transform.position;
            }
    }

    public void SelectColumn(int column)
    { 
        if (fallingPiece == null || fallingPiece.GetComponent<Rigidbody>().velocity == Vector3.zero)
        {
            Debug.Log("GameManager Column" + column);
            TakeTurn(column);
        }
   
    }

    void TakeTurn(int column)
    {
        if (UpdateBoardState(column))
        {
            player1Ghost.SetActive(false);
            player2Ghost.SetActive(false);

            if (Player1ChipTurn)
            {
                fallingPiece = Instantiate(Player1Chip, spawnLoc[column].transform.position, Quaternion.identity);
                fallingPiece.GetComponent<Rigidbody>().velocity = new Vector3(0, 0.1f, 0);
                Player1ChipTurn = false; 


                 if (Didwin(1))
                {
                    Debug.LogWarning("Player 1 won");
                }
            }
            else
            {
                
               fallingPiece =  Instantiate(Player2Chip, spawnLoc[column].transform.position, Quaternion.identity);
                fallingPiece. GetComponent<Rigidbody>().velocity = new Vector3(0, 0.1f, 0);
                Player1ChipTurn = true;

                if (Didwin(2))
                {
                    Debug.LogWarning("Player 2 won");
                }

            }
        }
    }


    bool UpdateBoardState(int column)
    {
        for (int row = 0; row < heightOfBoard; row++)
        {
            if (boardState[column, row] ==0)
            {
                if (Player1ChipTurn)
                {
                    boardState[column, row] = 1;
                }
                else
                {
                    boardState[column, row] = 2;
                }
                Debug.Log("Piece being spawned at ( " + column + "," + row + ")");
                return true;
            }
        }
        Debug.LogWarning("Column" + column + " is full");
        return false;
    }
    bool Didwin(int playerNum)
    {  

        //horizontal
        for(int x = 0; x < lengthOfBoard - 3 ; x++)
        {
            for(int y=0; y < heightOfBoard; y++)
            {
              if (boardState [x,y ] == playerNum && boardState [x + 1, y ] == playerNum && boardState[x + 2, y] == playerNum && boardState[x + 3, y] == playerNum)
                {
                    return true;
                }
            }
        }

    //vertical
    for (int x= 0; x < lengthOfBoard; x ++ )
        {
            for (int y = 0; y < heightOfBoard - 3; y++)
            {
                if (boardState[x, y] == playerNum && boardState[x + 1,y + 1 ] == playerNum && boardState[x + 2 , y + 2] == playerNum && boardState[x + 3 , y + 3] == playerNum)
                {
                    return true;
                }
            }
        }
    //y=x line
        for (int x = 0; x < lengthOfBoard-3; x++)
        {
            for (int y = 0; y < heightOfBoard - 3; y++)
            {
                if (boardState[x, y  ] == playerNum && boardState[x + 1,y + 1 ] == playerNum && boardState[x + 2 , y + 2 ] == playerNum && boardState[x + 3 , y = 3 ] == playerNum)
                {
                    return true;
                }
            }

        }
        //y=-xline
        for (int x = 0; x < lengthOfBoard - 3; x++)
        {
            for (int y = 0; y < heightOfBoard - 3; y++)
            {
                if (boardState[x, y + 3] == playerNum && boardState[x + 1, y + 2] == playerNum && boardState[x + 2, y + 1] == playerNum && boardState[x + 3, y] == playerNum)
                {
                    return true;
                }
            }

        }

        return false;
    }

}

