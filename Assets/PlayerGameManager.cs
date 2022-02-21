using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = UnityEditor.SearchService.Scene;

public class PlayerGameManager : MonoBehaviour
{
    
    
    public void OnVictory() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    
    
    
}
