using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    public TextMeshProUGUI healthtext;
    public Transform Player;
    [SerializeField] int _health = 3;
    [SerializeField] int _currentHealth = 3;
    [SerializeField] int _value = 0;
    [SerializeField] int _hitDamage = 1;

    public void GameOver()
    {
        //Destroy(this.gameObject);
        SceneManager.LoadScene(2);
        //_endPos = Player.position;
    }
    public void UpdateHealth()
    {
        _currentHealth --;
        healthtext.text = _currentHealth.ToString();

        if(_currentHealth < 1)
        {
            GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            //GetComponent<MeshRenderer>().material.color = Color.red;
            UpdateHealth();
        }
    }
}
