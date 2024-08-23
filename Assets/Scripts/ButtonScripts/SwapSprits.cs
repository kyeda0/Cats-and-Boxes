using UnityEngine;

public class SwapSprits : MonoBehaviour
{
   [SerializeField] private Sprite _spriteShop;


   public void SwapSkins(){
      GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().sprite = _spriteShop;
      GameObject.FindGameObjectWithTag("MainPlayer").GetComponent<SpriteRenderer>().sprite = _spriteShop;

   }
}
