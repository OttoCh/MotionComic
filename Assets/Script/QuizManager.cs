using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public static QuizManager instance;

    public BtnQuiz btnQuizA;
    public BtnQuiz btnQuizB;
    public BtnQuiz btnQuizC;
    public BtnQuiz btnQuizD;

    public Text txtQuestion;

    public ImageQuestion imageQuestion;

    public ScoreManager scoreManager;

    public ScoreSymbol[] indexQustions;

    public int indexSoal = 1;
    private int indexJawaban;
    private int indexQuestion;

    void Awake()
    {
        instance = this;

        setSoal();
    }
    
    void Update()
    {

    }

    public void setSoal()
    {
        switch(indexSoal)
        {
            case 1:
                txtQuestion.text = "Kapankah terjadinya peristiwa pengibaran bendera Belanda di Hotel Yamato?";
                btnQuizA.setText("17 September 1945");
                btnQuizB.setText("18 September 1945");
                btnQuizC.setText("19 September 1945");
                btnQuizD.setText("20 September 1945");
                indexJawaban = 3;
                break;
            case 2:
                txtQuestion.text = "Siapakah pemimpin BKR bagian Jawa Timur?";
                btnQuizA.setText("Drg. Moestopo");
                btnQuizB.setText("Abdul Wahab");
                btnQuizC.setText("Soengkono");
                btnQuizD.setText("Sutopo");
                indexJawaban = 1;
                break;
            case 3:
                txtQuestion.text = "Pada tanggal berapakah Inggris dan Belanda datang ke Surabaya?";
                btnQuizA.setText("21 Oktober 1945");
                btnQuizB.setText("25 Oktober 1945");
                btnQuizC.setText("21 September 1945");
                btnQuizD.setText("25 September 1945");
                indexJawaban = 2;
                break;
            case 4:
                txtQuestion.text = "Siapakah jendral Inggris yang tewas pada tanggal 30 Oktober 1945?";
                btnQuizA.setText("A.W.S Mallaby");
                btnQuizB.setText("Philip Christison");
                btnQuizC.setText("Mansergh");
                btnQuizD.setText("Howthorn");
                indexJawaban = 1;
                break;
            case 5:
                txtQuestion.text = "Siapakah pemimpin Barisan Pemberontak Rakyat Indonesia yang menyurakan semangat "+ 
                    "juangnya melalui siaran radio?";
                btnQuizA.setText("Bung Karno");
                btnQuizB.setText("Bung Hatta");
                btnQuizC.setText("Doel Arnowo");
                btnQuizD.setText("Bung Tomo");
                indexJawaban = 4;
                break;
            case 6:
                txtQuestion.text = "Siapakah nama tokoh di atas ini?";
                btnQuizA.setText("A.W.S Mallaby");
                btnQuizB.setText("Philip Christison");
                btnQuizC.setText("Mansergh");
                btnQuizD.setText("Howthorn");
                indexJawaban = 2;
                break;
            case 7:
                txtQuestion.text = "Berapa minggukah pertempuran surabaya terjadi?";
                btnQuizA.setText("1 minggu");
                btnQuizB.setText("2 minggu");
                btnQuizC.setText("3 minggu");
                btnQuizD.setText("4 minggu");
                indexJawaban = 3;
                break;
            case 8:
                txtQuestion.text = "Siapakah tokoh yang mengancam rakyat Surabaya dan memberi batas waktu "+
                    "untuk menyerah hingga 9 November? ";
                btnQuizA.setText("A.W.S Mallaby");
                btnQuizB.setText("Philip Christison");
                btnQuizC.setText("Mansergh");
                btnQuizD.setText("Howthorn");
                indexJawaban = 3;
                break;
            case 9:
                txtQuestion.text = "Dimanakah Jepang pertama kali mendarat di Indonesia? ";
                btnQuizA.setText("Banten");
                btnQuizB.setText("Jawa Barat");
                btnQuizC.setText("Jawa Tengah");
                btnQuizD.setText("Jawa Timur");
                indexJawaban = 1;
                break;
            case 10:
                txtQuestion.text = "Dimanakah pembentukan Komisi Nasional Indonesia Daerah Surabaya dilaksanakan?";
                btnQuizA.setText("Hotel Yamato");
                btnQuizB.setText("Gedung Gubernur");
                btnQuizC.setText("Markas Kempetai");
                btnQuizD.setText("Gedung Nasional Indonesia");
                indexJawaban = 4;
                break;
        }
        indexSoal++;
    }

    public void updateIndexQuestion()
    {
        indexQustions[indexQuestion].setBenar();
        indexQuestion++;
    }

    public void checkJawaban(int indexJawaban)
    {
        if (indexSoal < 12)
        {
            if (indexJawaban == this.indexJawaban)
            {
                scoreManager.increaseScore();
            }

            imageQuestion.updateImage();
            updateIndexQuestion();
            setSoal();
        }
        else if(indexSoal == 12)
        {
            GameObject audio = GameObject.Find("Audio Source").gameObject;
            if (audio != null) Destroy(audio);
            SceneManager.LoadScene("AfterKuis");
        }
    }
}
