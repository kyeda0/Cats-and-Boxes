using UnityEngine;

public class OpenAndCloseShop : MonoBehaviour
{
    [SerializeField] private Sprite _sprites;
    [SerializeField] private GameObject[] _ui;
    [SerializeField] private GameObject[] _uiShop;

    //public void SetSprits(){
   ///     GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().sprite = _sprites;
   // }
    public void OpenShop(){
        foreach (GameObject i in _ui)
        {
           i.SetActive(false);
        }

        foreach(GameObject i in _uiShop )
        {
            i.SetActive(true);
        }
    }   

    public void CloseShop(){
          foreach (GameObject i in _ui)
        {
           i.SetActive(true);
        }

        foreach(GameObject i in _uiShop )
        {
            i.SetActive(false);
        }
    }
}
