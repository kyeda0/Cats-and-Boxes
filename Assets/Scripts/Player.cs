using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GameObject _panel;
    [SerializeField] private GameObject _panell;
   // private int rand;
    //public Sprite[] sprites;
    Rigidbody2D _player;
    void Start()
    {
       // rand = Random.Range(0,sprites.Length);
       // GetComponent<SpriteRenderer>().sprite = sprites[rand];
        _player = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if(Input.GetMouseButton(0)) 
        {
            Vector3 _tochPos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
            if(_tochPos.x<0)
            {
                _player.AddForce(Vector2.left * _moveSpeed);
            }
            else
            {
                _player.AddForce(Vector2.right * _moveSpeed);    
            }

        }
        else
        {
            _player.velocity = Vector2.zero;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            _panel.SetActive(true);
            _panell.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
