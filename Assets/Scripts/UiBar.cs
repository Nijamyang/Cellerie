using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiBar : MonoBehaviour
{
    public Image imgBar;
    private float _maxHealth;
    private float _currentHealth;
    
    public void Initialize(float newMaxHealth)
    {
        _maxHealth = newMaxHealth;
        _currentHealth = _maxHealth;
        RecalculateBar();
    }
    
    void RecalculateBar()
    {
        imgBar.transform.localScale = new Vector2(_currentHealth / _maxHealth, 1);
    }
}
