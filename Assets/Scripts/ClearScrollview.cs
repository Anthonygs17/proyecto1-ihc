using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{
    public GameObject scrollViewContent;
    
    public void ClearScrollView()
    {
        if (scrollViewContent != null)
        {
            foreach (Transform child in scrollViewContent.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
