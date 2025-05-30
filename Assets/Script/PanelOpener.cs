using UnityEngine;

public class PanelOpener : MonoBehaviour
{
   public GameObject Panel;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Animator animator = Panel.GetComponent<Animator>();
            if (animator != null )
            {
                audioManager.PlaySFX(audioManager.usineOpen);
                bool isOpen = animator.GetBool("open");

                animator.SetBool("open", !isOpen);

            }
        }
    }
}
