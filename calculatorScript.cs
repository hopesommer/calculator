using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculatorScript : MonoBehaviour {
    string a = "";
    string b = "";
    string Divide = "Divide";
    string quotient2 = "";
    string Multiply = "Multiply";
    string Add = "Add";
    string Subtract = "Subtract";
    int randomNumber;
    int randomNumber1;
    int randomNumber2;
    int randomNumber3;
    int division;
    int subtraction;
    int multiplication;
    int addition;
    int checkNumber;

    void Start() {
        randomNumberGenerator();
    }

    int randomNumberGenerator()
    {
        randomNumber = Random.Range(1, 20);
        return randomNumber;

    }
    
    void OnTriggerEnter(Collider other)
      {
          print(other.gameObject);
          Destroy(other.gameObject);
      }

      void GameEnd()
      {
          print("Game over");
      }
      

    void OnGUI()
    {
        if(checkNumber == randomNumber1 || checkNumber == randomNumber1 || checkNumber == randomNumber2 || checkNumber == randomNumber3)
        {
            int randomNumber = randomNumberGenerator();
            int randomNumber1 = randomNumberGenerator();
            int randomNumber2 = randomNumberGenerator();
            int randomNumber3 = randomNumberGenerator();
        }
        if (randomNumber == division || randomNumber == multiplication || randomNumber == subtraction ||
            randomNumber == addition)
        {
            randomNumberGenerator();
        }


        a = GUI.TextField(new Rect(210, 235, 100, 35), a);
        b = GUI.TextField(new Rect(320, 235, 100, 35), b);

        if (GUI.Button(new Rect(165, 175, 50, 50), ""))
        {

            int integer_a = 0;
            int integer_b = 0;

            System.Int32.TryParse(a, out integer_a);
            System.Int32.TryParse(b, out integer_b);

            int division = (integer_a / integer_b);
            Divide = division.ToString();

        }



        if (GUI.Button(new Rect(230, 175, 50, 50), ""))
        {

            int integer_a = 0;
            int integer_b = 0;

            System.Int32.TryParse(a, out integer_a);
            System.Int32.TryParse(b, out integer_b);

            int multiplication = (integer_a * integer_b);
            Multiply = multiplication.ToString();

        }

        if (GUI.Button(new Rect(295, 175, 50, 50), ""))
        {

            int integer_a = 0;
            int integer_b = 0;

            System.Int32.TryParse(a, out integer_a);
            System.Int32.TryParse(b, out integer_b);

            int Addition = (integer_a + integer_b);
            Add = Addition.ToString();

        }

        if (GUI.Button(new Rect(360, 175, 50, 50), ""))
        {

            int integer_a = 0;
            int integer_b = 0;

            System.Int32.TryParse(a, out integer_a);
            System.Int32.TryParse(b, out integer_b);

            int Subtraction = (integer_a - integer_b);
            Subtract = Subtraction.ToString();

        }

        if (GUI.Button(new Rect(425, 175, 50, 50), "Clear"))
        {
            a = "0";
            b = "0";
            Divide = "Divide";
            quotient2 = "Divide";
            Multiply = "Multiply";
            Add = "Add";
            Subtract = "Subtract";
        }



        GUI.Label(new Rect(165, 175, 50, 50), Divide);
        GUI.Label(new Rect(230, 175, 50, 50), Multiply);
        GUI.Label(new Rect(295, 175, 50, 50), Add);
        GUI.Label(new Rect(360, 175, 50, 50), Subtract);
    }
    }
    // Use this for initialization
  
	
	// Update is called once per frame

    
