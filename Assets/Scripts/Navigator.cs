using UnityEngine;

public class Navigator : MonoBehaviour
{
    [SerializeField] private GameObject _currentView;
    [SerializeField] private GameObject _nextView;

    void OnMouseUp()
    {
        ViewerManager.Instance.LoadNextView(_currentView, _nextView);
    }
}
