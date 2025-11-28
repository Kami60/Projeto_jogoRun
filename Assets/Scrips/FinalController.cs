using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalController : MonoBehaviour
{
  
    [SerializeField] TMPro.TMP_Text coinTxt;
    [SerializeField] TMPro.TMP_Text gemTxt;
    [SerializeField] TMPro.TMP_Text distanceTxt;
    [SerializeField] TMPro.TMP_Text fraseTxt;

  //  [SerializeField] GameObject fadeOut;
   // [SerializeField] GameObject fadeIn;

    void Start()
    {
       // StartCoroutine(FadeInTurnOff());

        
        coinTxt.text = "" + MasterInfo.coinCount;
        gemTxt.text = "" + MasterInfo.gemCount;
        distanceTxt.text = "" + MasterInfo.distanceRun;

        fraseTxt.text = ObterFrase();
    }



    public void BotaoJogarNovamente()
    {
        StartCoroutine(StartGameAgain());
    }

    IEnumerator StartGameAgain()
    {
       // fadeOut.SetActive(true);
      yield return new WaitForSeconds(1);

        ResetarValores();
        SceneManager.LoadScene(1);
    }

   
    public void BotaoVoltarMenu()
    {
        StartCoroutine(ReturnToMenu());
    }

    IEnumerator ReturnToMenu()
    {
       // fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);

        ResetarValores();
        SceneManager.LoadScene(0);
    }

    IEnumerator FadeInTurnOff()
    {
        yield return new WaitForSeconds(1);
      //  fadeIn.SetActive(false);
    }

    void ResetarValores()
    {
        MasterInfo.coinCount = 0;
        MasterInfo.gemCount = 0;
        MasterInfo.distanceRun = 0;
    }

    string ObterFrase()
    {
        int coins = MasterInfo.coinCount;

        if (coins == 0) return "Um dia você consegue!";
        if (coins < 10) return "Boa! Pegou algumas moedas!";
        if (coins < 30) return "Ótima corrida!";
        if (coins < 60) return "Excelente! Tá ficando bom!";
        return "INCRÍVEL! Você é uma lenda!";
    }
}