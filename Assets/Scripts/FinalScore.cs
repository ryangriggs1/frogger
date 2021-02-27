using UnityEngine.UI;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public static int finalScore = 0;
    public Text finalText;
    private void Start()
    {
        finalText.text = finalScore.ToString();
    }

}
