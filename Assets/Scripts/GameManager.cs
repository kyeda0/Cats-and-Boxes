using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{

    [SerializeField] private AudioSource music;
    [SerializeField] private GameObject _mainPanel;
    [SerializeField] private GameObject[] _textUI;
    [SerializeField] private GameObject _player;
     private bool _gameStarted = false;

    private void Start()
    {
        music.Stop();
    }
    public void StartGame(){
       if (!_gameStarted)
        {
          
            GameObject.FindGameObjectWithTag("SpawnPoint").GetComponent<SpawnBlocks>().StartSpawning();
            GameObject.FindGameObjectWithTag("Animations").GetComponent<AnimationsScripts>().StopAnimation();
            GameObject.FindGameObjectWithTag("Animations").GetComponent<AnimationsScripts>().StartAnimation(); 
            _gameStarted = true;
            _mainPanel.SetActive(true);
            foreach (GameObject i in _textUI){
                i.SetActive(false);
            }  
            _player.transform.position = new Vector3(-0.1175f,-4.1638f,0);
            Time.timeScale = 1f;
        }
          // music.loop = true;
            //music.Play();
        //} 
    }
}
