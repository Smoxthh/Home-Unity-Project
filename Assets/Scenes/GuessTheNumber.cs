using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GuessTheNumber : MonoBehaviour
{

    public TMP_Text messageText;
    public TMP_InputField NumberInput;

    private int randomNumber;

    // Zone rng du nombre choisis par l'ordi
    private void Start()
    {
        ResetGame();
    }
    // zone public Bouton Try
    public void Try()
    {
        if (string.IsNullOrWhiteSpace(NumberInput.text))//on peut mettre ==true apres
        {
            messageText.text = "Enter a Number Please!";//on vide la zone number et on arrete avec return
            NumberInput.text = "";
            return;
        }
        //Zone reponse a la reponse donner par le joueur
        if (int.TryParse(NumberInput.text, out int playerNumber))
        {
            if (playerNumber == randomNumber)      // si player number est égal a randomNumber
            {
                messageText.text = "Victory! ;) ";     // Victoire ( channger le message, reset le champ texte
            }
            else if (playerNumber > randomNumber)  // Si playerNumber est sup a randomNumber
            {
                messageText.text = "Lower...!";    // Annoncer "moins"
            }
            else if (playerNumber < randomNumber)  // Si playerNumber est inférieur a randomNumber
            {
                messageText.text = "Greater..";  // Annoncer 
            }
        }

        //Zone chiffre non valide
        else
        {
            messageText.text = "Please Enter Valide Number";//on vide la zone number et on arrete avec return
        }
        NumberInput.text = "";
    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);//100+ 1 ou 101 les deux marchent. RandomNumber cherche un nombre Range = entre 1 inclus 101 pour que 100 soit inclus 
        Debug.Log("Generate Number: " + randomNumber);
        messageText.text = "Let's Go !!!";
    }


}
