using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    // טעינת הסצנצה לפי שם
    public void ChangeScene (string scneName)
    {
        SceneManager.LoadScene(scneName);
    }
}
