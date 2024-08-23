using UnityEngine;
using TMPro;
using UnityEditor;

public class TextScore : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI _hightScoreText;
    private int _score = 0;
    private TextMeshProUGUI _scoreText;

 public void AddScore(){
    _score++;
   _hightScoreText.text = transform.GetComponent<TextMeshProUGUI>().text = _score.ToString();
 }
}
