using UnityEngine;

public class AnimationsScripts : MonoBehaviour
{
    [SerializeField] public Animator _animatorImage;
    [SerializeField] public Animator _animatorPlayer;
 


 public void StartAnimation(){
    _animatorImage.SetBool("Start",true);
    _animatorPlayer.SetBool("StartPlayer",true);
 }


 public void StopAnimation(){
    _animatorImage.SetBool("Start",false);
    _animatorPlayer.SetBool("StartPlayer",false);
 }
}
