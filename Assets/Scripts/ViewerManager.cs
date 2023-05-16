using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ViewerManager : MonoBehaviour
{
    private static ViewerManager instance = null;
    public static ViewerManager Instance
    {
        get
        {
            if (instance == null)
                instance = GameObject.FindObjectOfType(typeof(ViewerManager)) as ViewerManager;
            return instance;
        }
    }

    public List<GameObject> views;

    private void Start()
    {
        ResetViews();
    }

    void ResetViews()
    {
        foreach (GameObject go in views)
            go.SetActive(false);

        views[0].SetActive(true);
    }

    public void LoadNextView(GameObject current, GameObject next)
    {
        StartCoroutine(TransitionHandle(current, next));
    }

    private IEnumerator TransitionHandle(GameObject currentView, GameObject nextView)
    {

        yield return new WaitForSeconds(1.5f);
        currentView.SetActive(false);
        nextView.SetActive(true);


    }

}
