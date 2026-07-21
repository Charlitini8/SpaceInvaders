using UnityEngine;
using UnityEngine.Events;

public class GazeButton : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPointerEnter;
    [SerializeField]
    private UnityEvent onPointerExit;
    [SerializeField]
    private UnityEvent onPointerClick;
    [SerializeField]
    private string OnPointerEnterAnimationName;
    [SerializeField]
    private string OnPointerExitAnimationName;
    [SerializeField]
    private string OnPointerClickAnimationName;
    [SerializeField]
    private Animator animator;
    public void OnPointerEnter()
    {
        animator.Play(OnPointerEnterAnimationName, 0, 0f);
        onPointerEnter?.Invoke();
    }
    public void OnPointerExit()
    {
        animator.Play(OnPointerExitAnimationName, 0, 0f);
        onPointerExit?.Invoke();
    }
    public void OnPointerClick()
    {
        animator.Play(OnPointerClickAnimationName, 0, 0f);
        onPointerClick?.Invoke();
    }
}
