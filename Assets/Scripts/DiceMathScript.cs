// BUGS:
//  - Pēc katra metiena refresho "pašlaik punkti" (kopš ieviesa kauliņu izdzešanu)
//  - Kad saglabā punktus ("Paturēt punktus") nenodzēšas "pašlaik punkti" skaits

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DiceMathScript : MonoBehaviour {
    int totalCurrentResult, totalResult, currentResult, x, y, z, i, j, t;

    public GameObject totalResultText;
    public GameObject totalCurrentResultText;
    public GameObject Dices;

    public GameObject DiceOne;
    public GameObject DiceTwo;
    public GameObject DiceThree;
    public GameObject DiceFour;
    public GameObject DiceFive;
    public GameObject DiceSix;

    public GameObject DiceCheckZone;

    public float cooldownTime = 1f;
    private float timer;

    public bool resultAdded = false;

    private void Start() {
        timer = 0f;
    }

    public void Update() {
        currentResult = checkOnes(x) + checkTwos(y) + checkFives(z) + checkThrees(i) + checkFours(j) + checkSixes(t);
        if (!resultAdded) {
            totalCurrentResult = currentResult + totalCurrentResult;
            PlayerPrefs.SetInt("TotalCurrentResult", totalCurrentResult);
            resultAdded = true;
        }
        int testResult = totalCurrentResult + currentResult;
        totalCurrentResultText.GetComponent<Text>().text = "Pašlaik punkti: " + testResult;

        if (timer > 0) {
            timer -= Time.deltaTime;
        }
    }

    public void addTotalCurrentResult() {
        Dices.transform.position += new Vector3(0, 0.5f, 0);
        resultAdded = false;
        DiceCheckZone.SetActive(true);

        timer = cooldownTime;
    }

    public void addTotalResult() {
        totalResult += totalCurrentResult + currentResult;
        totalCurrentResult = 0;
        currentResult = 0;
        PlayerPrefs.SetInt("TotalResult", totalResult);
        totalResultText.GetComponent<Text>().text = "Kopā punkti: " + totalResult;

        //Dices.transform.position += new Vector3(0, 1, 0);
        Destroy(Dices);
        PlayerPrefs.SetInt("TotalCurrentResult", totalCurrentResult);
    }

    int checkOnes(int x) {
        int[] variables = new int[] { DiceOneScript.result, DiceTwoScript.result, DiceThreeScript.result, DiceFourScript.result, DiceFiveScript.result, DiceSixScript.result };
        int count = variables.Count(y => y == 1);
        if (timer < 0) {
            if (count >= 6) {
                Destroy(Dices);

                return x + 8000;
            }

            if (count >= 5) {
                if (variables[0] == 1) { Destroy(DiceOne);}
                if (variables[1] == 1) { Destroy(DiceTwo);}
                if (variables[2] == 1) { Destroy(DiceThree);}
                if (variables[3] == 1) { Destroy(DiceFour);}
                if (variables[4] == 1) { Destroy(DiceFive);}
                if (variables[5] == 1) { Destroy(DiceSix);}

                return x + 4000;
            }

            if (count >= 4) {
                if (variables[0] == 1) { Destroy(DiceOne);}
                if (variables[1] == 1) { Destroy(DiceTwo);}
                if (variables[2] == 1) { Destroy(DiceThree);}
                if (variables[3] == 1) { Destroy(DiceFour);}
                if (variables[4] == 1) { Destroy(DiceFive);}
                if (variables[5] == 1) { Destroy(DiceSix);}

                return x + 2000;
            }

            if (count >= 3) {
                if (variables[0] == 1) { Destroy(DiceOne);}
                if (variables[1] == 1) { Destroy(DiceTwo);}
                if (variables[2] == 1) { Destroy(DiceThree);}
                if (variables[3] == 1) { Destroy(DiceFour);}
                if (variables[4] == 1) { Destroy(DiceFive);}
                if (variables[5] == 1) { Destroy(DiceSix);}

                return x + 1000;
            }

            if (count >= 2) {
                if (variables[0] == 1) { Destroy(DiceOne);}
                if (variables[1] == 1) { Destroy(DiceTwo);}
                if (variables[2] == 1) { Destroy(DiceThree);}
                if (variables[3] == 1) { Destroy(DiceFour);}
                if (variables[4] == 1) { Destroy(DiceFive);}
                if (variables[5] == 1) { Destroy(DiceSix);}

                return x + 200;
            }

            if (count >= 1) {
                if (variables[0] == 1) { Destroy(DiceOne);}
                if (variables[1] == 1) { Destroy(DiceTwo);}
                if (variables[2] == 1) { Destroy(DiceThree);}
                if (variables[3] == 1) { Destroy(DiceFour);}
                if (variables[4] == 1) { Destroy(DiceFive);}
                if (variables[5] == 1) { Destroy(DiceSix);}

                return x + 100;
            }
            
        }
        return x;
    }

    int checkFives(int x) {
        int[] variables = new int[] { DiceOneScript.result, DiceTwoScript.result, DiceThreeScript.result, DiceFourScript.result, DiceFiveScript.result, DiceSixScript.result };
        int count = variables.Count(y => y == 5);
        if (timer < 0) {
            if (count >= 6) {
                Destroy(Dices);

                return x + 4000;
            }

            if (count >= 5) {
                if (variables[0] == 5) { Destroy(DiceOne);}
                if (variables[1] == 5) { Destroy(DiceTwo);}
                if (variables[2] == 5) { Destroy(DiceThree);}
                if (variables[3] == 5) { Destroy(DiceFour);}
                if (variables[4] == 5) { Destroy(DiceFive);}
                if (variables[5] == 5) { Destroy(DiceSix);}

                return x + 2000; 
            }

            if (count >= 4) {
                if (variables[0] == 5) { Destroy(DiceOne);}
                if (variables[1] == 5) { Destroy(DiceTwo);}
                if (variables[2] == 5) { Destroy(DiceThree);}
                if (variables[3] == 5) { Destroy(DiceFour);}
                if (variables[4] == 5) { Destroy(DiceFive);}
                if (variables[5] == 5) { Destroy(DiceSix);}

                return x + 1000; 
            }

            if (count >= 3) {
                if (variables[0] == 5) { Destroy(DiceOne);}
                if (variables[1] == 5) { Destroy(DiceTwo);}
                if (variables[2] == 5) { Destroy(DiceThree);}
                if (variables[3] == 5) { Destroy(DiceFour);}
                if (variables[4] == 5) { Destroy(DiceFive);}
                if (variables[5] == 5) { Destroy(DiceSix);}

                return x + 500;
            }

            if (count >= 2) {
                if (variables[0] == 5) { Destroy(DiceOne);}
                if (variables[1] == 5) { Destroy(DiceTwo);}
                if (variables[2] == 5) { Destroy(DiceThree);}
                if (variables[3] == 5) { Destroy(DiceFour);}
                if (variables[4] == 5) { Destroy(DiceFive);}
                if (variables[5] == 5) { Destroy(DiceSix);}

                return x + 100; 
            }

            if (count >= 1) {
                if (variables[0] == 5) { Destroy(DiceOne);}
                if (variables[1] == 5) { Destroy(DiceTwo);}
                if (variables[2] == 5) { Destroy(DiceThree);}
                if (variables[3] == 5) { Destroy(DiceFour);}
                if (variables[4] == 5) { Destroy(DiceFive);}
                if (variables[5] == 5) { Destroy(DiceSix);}

                return x + 50; 
            }
            
        }
        return x;
    }

    int checkTwos(int x) {
        int[] variables = new int[] { DiceOneScript.result, DiceTwoScript.result, DiceThreeScript.result, DiceFourScript.result, DiceFiveScript.result, DiceSixScript.result };
        int count = variables.Count(y => y == 2);
        if (timer < 0) {
            if (count >= 6) {
                Destroy(Dices);

                return x + 1600;
            }

            if (count >= 5) {
                if (variables[0] == 2) { Destroy(DiceOne);}
                if (variables[1] == 2) { Destroy(DiceTwo);}
                if (variables[2] == 2) { Destroy(DiceThree);}
                if (variables[3] == 2) { Destroy(DiceFour);}
                if (variables[4] == 2) { Destroy(DiceFive);}
                if (variables[5] == 2) { Destroy(DiceSix);}

                return x + 800; 
            }

            if (count >= 4) {
                if (variables[0] == 2) { Destroy(DiceOne);}
                if (variables[1] == 2) { Destroy(DiceTwo);}
                if (variables[2] == 2) { Destroy(DiceThree);}
                if (variables[3] == 2) { Destroy(DiceFour);}
                if (variables[4] == 2) { Destroy(DiceFive);}
                if (variables[5] == 2) { Destroy(DiceSix);}

                return x + 400; 
            }

            if (count >= 3) {
                if (variables[0] == 2) { Destroy(DiceOne);}
                if (variables[1] == 2) { Destroy(DiceTwo);}
                if (variables[2] == 2) { Destroy(DiceThree);}
                if (variables[3] == 2) { Destroy(DiceFour);}
                if (variables[4] == 2) { Destroy(DiceFive);}
                if (variables[5] == 2) { Destroy(DiceSix);}

                return x + 200;
            }
            
        }
        return x;
    }

    int checkThrees(int x) {
        int[] variables = new int[] { DiceOneScript.result, DiceTwoScript.result, DiceThreeScript.result, DiceFourScript.result, DiceFiveScript.result, DiceSixScript.result };
        int count = variables.Count(y => y == 3);
        if (timer < 0) {
            if (count >= 6) {
                Destroy(Dices);

                return x + 2400;
            }

            if (count >= 5) {
                if (variables[0] == 3) { Destroy(DiceOne);}
                if (variables[1] == 3) { Destroy(DiceTwo);}
                if (variables[2] == 3) { Destroy(DiceThree);}
                if (variables[3] == 3) { Destroy(DiceFour);}
                if (variables[4] == 3) { Destroy(DiceFive);}
                if (variables[5] == 3) { Destroy(DiceSix);}

                return x + 1200; 
            }

            if (count >= 4) {
                if (variables[0] == 3) { Destroy(DiceOne);}
                if (variables[1] == 3) { Destroy(DiceTwo);}
                if (variables[2] == 3) { Destroy(DiceThree);}
                if (variables[3] == 3) { Destroy(DiceFour);}
                if (variables[4] == 3) { Destroy(DiceFive);}
                if (variables[5] == 3) { Destroy(DiceSix);}

                return x + 600; 
            }

            if (count >= 3) {
                if (variables[0] == 3) { Destroy(DiceOne);}
                if (variables[1] == 3) { Destroy(DiceTwo);}
                if (variables[2] == 3) { Destroy(DiceThree);}
                if (variables[3] == 3) { Destroy(DiceFour);}
                if (variables[4] == 3) { Destroy(DiceFive);}
                if (variables[5] == 3) { Destroy(DiceSix);}

                return x + 300;
            }
            
        }
        return x;
    }

    int checkFours(int x) {
        int[] variables = new int[] { DiceOneScript.result, DiceTwoScript.result, DiceThreeScript.result, DiceFourScript.result, DiceFiveScript.result, DiceSixScript.result };
        int count = variables.Count(y => y == 4);
        if (timer < 0) {
            if (count >= 6) {
                Destroy(Dices);

                return x + 3200;
            }

            if (count >= 5) {
                if (variables[0] == 4) { Destroy(DiceOne);}
                if (variables[1] == 4) { Destroy(DiceTwo);}
                if (variables[2] == 4) { Destroy(DiceThree);}
                if (variables[3] == 4) { Destroy(DiceFour);}
                if (variables[4] == 4) { Destroy(DiceFive);}
                if (variables[5] == 4) { Destroy(DiceSix);}

                return x + 1600; 
            }

            if (count >= 4) {
                if (variables[0] == 4) { Destroy(DiceOne);}
                if (variables[1] == 4) { Destroy(DiceTwo);}
                if (variables[2] == 4) { Destroy(DiceThree);}
                if (variables[3] == 4) { Destroy(DiceFour);}
                if (variables[4] == 4) { Destroy(DiceFive);}
                if (variables[5] == 4) { Destroy(DiceSix);}

                return x + 800; 
            }

            if (count >= 3) {
                if (variables[0] == 4) { Destroy(DiceOne);}
                if (variables[1] == 4) { Destroy(DiceTwo);}
                if (variables[2] == 4) { Destroy(DiceThree);}
                if (variables[3] == 4) { Destroy(DiceFour);}
                if (variables[4] == 4) { Destroy(DiceFive);}
                if (variables[5] == 4) { Destroy(DiceSix);}

                return x + 400;
            }
            
        }
        return x;
    }

    int checkSixes(int x) {
        int[] variables = new int[] { DiceOneScript.result, DiceTwoScript.result, DiceThreeScript.result, DiceFourScript.result, DiceFiveScript.result, DiceSixScript.result };
        int count = variables.Count(y => y == 6);
        if (timer < 0) {
            if (count >= 6) {
                Destroy(Dices);

                return x + 4800;
            }

            if (count >= 5) {
                if (variables[0] == 6) { Destroy(DiceOne);}
                if (variables[1] == 6) { Destroy(DiceTwo);}
                if (variables[2] == 6) { Destroy(DiceThree);}
                if (variables[3] == 6) { Destroy(DiceFour);}
                if (variables[4] == 6) { Destroy(DiceFive);}
                if (variables[5] == 6) { Destroy(DiceSix);}

                return x + 2400; 
            }

            if (count >= 4) {
                if (variables[0] == 6) { Destroy(DiceOne);}
                if (variables[1] == 6) { Destroy(DiceTwo);}
                if (variables[2] == 6) { Destroy(DiceThree);}
                if (variables[3] == 6) { Destroy(DiceFour);}
                if (variables[4] == 6) { Destroy(DiceFive);}
                if (variables[5] == 6) { Destroy(DiceSix);}

                return x + 1200; 
            }

            if (count >= 3) {
                if (variables[0] == 6) { Destroy(DiceOne);}
                if (variables[1] == 6) { Destroy(DiceTwo);}
                if (variables[2] == 6) { Destroy(DiceThree);}
                if (variables[3] == 6) { Destroy(DiceFour);}
                if (variables[4] == 6) { Destroy(DiceFive);}
                if (variables[5] == 6) { Destroy(DiceSix);}

                return x + 600;
            }
        }
        return x;
    }
}