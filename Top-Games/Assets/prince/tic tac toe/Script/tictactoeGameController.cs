using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class tictactoeGameController : MonoBehaviour
{
    public string[,] tictactoeArray = new string[,]{ { "?", "?", "?" },
                                                     { "?", "?", "?" },
                                                     { "?", "?", "?" } };
    //row 1
    public GameObject tictactoeButton00 = new GameObject();
    public GameObject tictactoeButton01 = new GameObject();
    public GameObject tictactoeButton02 = new GameObject();
    //row 2
    public GameObject tictactoeButton10 = new GameObject();
    public GameObject tictactoeButton11 = new GameObject();
    public GameObject tictactoeButton12 = new GameObject();
    //row 3
    public GameObject tictactoeButton20 = new GameObject();
    public GameObject tictactoeButton21 = new GameObject();
    public GameObject tictactoeButton22 = new GameObject();

    public GameObject X = new GameObject();
    public GameObject O = new GameObject();

    public GameObject playAgainButton0bj;
    public Button playAgainButton;
    public TextMeshProUGUI message;

    bool gameEnd;

    int round = 0;

    // Start is called before the first frame update
    void Start()
    {
        message.enabled = false;
        playAgainButton0bj.SetActive(false);
        gameEnd = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameEnd)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == tictactoeButton00.name && tictactoeArray[0, 0] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[0, 0] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton00.transform.position.x, tictactoeButton00.transform.position.y, tictactoeButton00.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[0, 0] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton00.transform.position.x, tictactoeButton00.transform.position.y, tictactoeButton00.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton01.name && tictactoeArray[0, 1] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[0, 1] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton01.transform.position.x, tictactoeButton01.transform.position.y, tictactoeButton01.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[0, 1] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton01.transform.position.x, tictactoeButton01.transform.position.y, tictactoeButton01.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton02.name && tictactoeArray[0, 2] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[0, 2] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton02.transform.position.x, tictactoeButton02.transform.position.y, tictactoeButton02.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[0, 2] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton02.transform.position.x, tictactoeButton02.transform.position.y, tictactoeButton02.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton10.name && tictactoeArray[1, 0] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[1, 0] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton10.transform.position.x, tictactoeButton10.transform.position.y, tictactoeButton10.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[1, 0] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton10.transform.position.x, tictactoeButton10.transform.position.y, tictactoeButton10.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton11.name && tictactoeArray[1, 1] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[1, 1] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton11.transform.position.x, tictactoeButton11.transform.position.y, tictactoeButton11.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[1, 1] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton11.transform.position.x, tictactoeButton11.transform.position.y, tictactoeButton11.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton12.name && tictactoeArray[1, 2] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[1, 2] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton12.transform.position.x, tictactoeButton12.transform.position.y, tictactoeButton12.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[1, 2] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton12.transform.position.x, tictactoeButton12.transform.position.y, tictactoeButton12.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton20.name && tictactoeArray[2, 0] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[2, 0] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton20.transform.position.x, tictactoeButton20.transform.position.y, tictactoeButton20.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[2, 0] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton20.transform.position.x, tictactoeButton20.transform.position.y, tictactoeButton20.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton21.name && tictactoeArray[2, 1] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[2, 1] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton21.transform.position.x, tictactoeButton21.transform.position.y, tictactoeButton21.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[2, 1] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton21.transform.position.x, tictactoeButton21.transform.position.y, tictactoeButton21.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }
                else if (hit.transform.name == tictactoeButton22.name && tictactoeArray[2, 2] == "?")
                {
                    if (round % 2 == 0)
                    {
                        tictactoeArray[2, 2] = "X";
                        round++;
                        Instantiate(X, new Vector3(tictactoeButton22.transform.position.x, tictactoeButton22.transform.position.y, tictactoeButton22.transform.position.z), Quaternion.identity);
                    }
                    else
                    {
                        tictactoeArray[2, 2] = "O";
                        round++;
                        Instantiate(O, new Vector3(tictactoeButton22.transform.position.x, tictactoeButton22.transform.position.y, tictactoeButton22.transform.position.z), Quaternion.identity);
                    }
                    checkWiner();
                }

            }
        }
    }

    private void checkWiner()
    {
        if ((tictactoeArray[0, 0] == "O" && tictactoeArray[0, 1] == "O" && tictactoeArray[0, 2] == "O")
            || (tictactoeArray[1, 0] == "O" && tictactoeArray[1, 1] == "O" && tictactoeArray[1, 2] == "O")
            || (tictactoeArray[2, 0] == "O" && tictactoeArray[2, 1] == "O" && tictactoeArray[2, 2] == "O")
            || (tictactoeArray[0, 0] == "O" && tictactoeArray[1, 0] == "O" && tictactoeArray[2, 0] == "O")
            || (tictactoeArray[0, 1] == "O" && tictactoeArray[1, 1] == "O" && tictactoeArray[2, 1] == "O")
            || (tictactoeArray[0, 2] == "O" && tictactoeArray[1, 2] == "O" && tictactoeArray[2, 2] == "O")
            || (tictactoeArray[0, 0] == "O" && tictactoeArray[1, 1] == "O" && tictactoeArray[2, 2] == "O")
            || (tictactoeArray[0, 2] == "O" && tictactoeArray[1, 1] == "O" && tictactoeArray[2, 0] == "O"))
        {
            playAgainButton0bj.SetActive(true);
            message.enabled = true;
            message.text = "Winer Is O";
            gameEnd = true;
        }
        else if ((tictactoeArray[0, 0] == "X" && tictactoeArray[0, 1] == "X" && tictactoeArray[0, 2] == "X")
           || (tictactoeArray[1, 0] == "X" && tictactoeArray[1, 1] == "X" && tictactoeArray[1, 2] == "X")
           || (tictactoeArray[2, 0] == "X" && tictactoeArray[2, 1] == "X" && tictactoeArray[2, 2] == "X")
           || (tictactoeArray[0, 0] == "X" && tictactoeArray[1, 0] == "X" && tictactoeArray[2, 0] == "X")
           || (tictactoeArray[0, 1] == "X" && tictactoeArray[1, 1] == "X" && tictactoeArray[2, 1] == "X")
           || (tictactoeArray[0, 2] == "X" && tictactoeArray[1, 2] == "X" && tictactoeArray[2, 2] == "X")
           || (tictactoeArray[0, 0] == "X" && tictactoeArray[1, 1] == "X" && tictactoeArray[2, 2] == "X")
           || (tictactoeArray[0, 2] == "X" && tictactoeArray[1, 1] == "X" && tictactoeArray[2, 0] == "X"))
        {
            playAgainButton0bj.SetActive(true);
            message.enabled = true;
            message.text = "Winer Is X";
            gameEnd = true;
        }
        else if(round==9)
        {
            playAgainButton0bj.SetActive(true);
            message.enabled = true;
            message.text = "No Winer";
            gameEnd = true;
        }
        
    }

    public void playAgain()
    {
        tictactoeArray = new string[,]{ { "?", "?", "?" },
                                                     { "?", "?", "?" },
                                                     { "?", "?", "?" } };
        round = 0;
        message.enabled = false;
        playAgainButton0bj.SetActive(false);
        gameEnd = false;
        GameObject[] delObj = GameObject.FindGameObjectsWithTag("X(Clone)");
        foreach (GameObject obj in delObj)
        {
            Destroy(obj);
        }
        delObj = GameObject.FindGameObjectsWithTag("O(Clone)");
        foreach (GameObject obj in delObj)
        {
            Destroy(obj);

        }

    }
}
