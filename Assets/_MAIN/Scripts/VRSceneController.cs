using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRSceneController : MonoBehaviour
{
    [SerializeField]
    private string nextScene;
    
    public AudioSource voiceOver;

    // Start is called before the first frame update
    void Start()
    {
        //voiceOver = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        if (!voiceOver.isPlaying)
        {
            IEnumerator LoadChangeScene()
            {
                yield return new WaitForSeconds(1f);
                SceneManager.LoadScene(nextScene);
            }
            StartCoroutine(LoadChangeScene());
        }
    }
}
