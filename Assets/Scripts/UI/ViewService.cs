using UnityEngine;

public class ViewService : MonoBehaviour
{
    private const string VIEW_PATH = "Prefabs/UI/View";
    [SerializeField] private RectTransform viewContainer;

    public T LoadView<T>() where T : AbstractView
    {
        //Assets/Resources/Prefabs/UI/View/StartView.prefab
        string viewName = typeof(T).Name;

        T viewPrefab = Resources.Load<T>($"{VIEW_PATH}/{viewName}");
        return Object.Instantiate(viewPrefab, viewContainer);
    }
}