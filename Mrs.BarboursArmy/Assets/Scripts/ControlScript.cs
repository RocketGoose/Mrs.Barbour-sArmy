using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScript : MonoBehaviour
{

    public GameObject morph; 
    public GameObject hogBacks;
    public GameObject hogBackB;

    Animator morphAnimator;
    Animator hogbacksAnimator;
    Animator hogbackBAnimator;

    
    void Start()
    {
        morphAnimator = morph.GetComponent<Animator>();
        hogbacksAnimator = hogBacks.GetComponent<Animator>();
        hogbackBAnimator = hogBackB.GetComponent<Animator>();

        StartCoroutine(IntroSequence());
    }

    
    void Update()
    {
        
    }

    public IEnumerator IntroSequence()
    {
        morphAnimator.SetBool("Morph1", true);
        hogbacksAnimator.SetBool("HogBacks1", true);
        hogbackBAnimator.SetBool("HogbackB1", true);
        yield return new WaitForSeconds(1);
        morphAnimator.SetBool("Morph1", false);
        hogbacksAnimator.SetBool("HogBacks1", false);
        hogbackBAnimator.SetBool("HogbackB1", false);

        yield return new WaitForSeconds(12);

        StartCoroutine(IntractSequence());

    }

    public IEnumerator IntractSequence()
    {
        yield return new WaitForSeconds(3);
        morphAnimator.SetBool("Morph2", true);
        hogbacksAnimator.SetBool("HogBacks2", true);
        hogbackBAnimator.SetBool("HogbackB2", true);
        yield return new WaitForSeconds(1);
        morphAnimator.SetBool("Morph2", false);
        hogbacksAnimator.SetBool("HogBacks2", false);
        hogbackBAnimator.SetBool("HogbackB2", false);

        yield return new WaitForSeconds(12);

        StartCoroutine(OutroSequence());

    }

    public IEnumerator OutroSequence()
    {
        yield return new WaitForSeconds(3);
        morphAnimator.SetBool("Morph3", true);
        hogbackBAnimator.SetBool("HogbackB3", true);
        yield return new WaitForSeconds(1);
        morphAnimator.SetBool("Morph3", false);
        hogbackBAnimator.SetBool("HogbackB3", false);

        yield return new WaitForSeconds(12);

    }
}
