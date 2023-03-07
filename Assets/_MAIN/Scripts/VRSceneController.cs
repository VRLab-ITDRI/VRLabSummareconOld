using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRSceneController : MonoBehaviour
{
    [SerializeField]
    private string nextScene;
    
    //public AudioSource voiceOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // detect audio source when enter isComplete phase
        //AutoChangeScene();
    }

    public void NextScene()
    {
        StartCoroutine(LoadChangeScene());
    }

    //internal void AutoChangeScene()
    //{
    //    if (!voiceOver.isPlaying)
    //    {
    //        StartCoroutine(LoadChangeScene());
    //    }
    //}

    IEnumerator LoadChangeScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextScene);
    }
}
