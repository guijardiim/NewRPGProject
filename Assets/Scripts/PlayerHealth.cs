/*using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    public void ChangeHealth(int amount)
    {
        currentHealth  += amount;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);

        }  
        

    
    }



}
*/
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    [Header("Configurações de Vida")]
    public int maxHealth = 100;
    public int currentHealth;
    public Animator healthBarAnim;

    [Header("Interface (UI)")]
    public Slider healthSlider; // Arraste o Slider da sua UI aqui no Inspetor

    void Start()
    {
        currentHealth = maxHealth;

        // Configura o slider no início do jogo
        if (healthSlider != null)
        {
            healthSlider.maxValue = maxHealth;
            healthSlider.value = currentHealth;
        }
    }

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        healthBarAnim.Play("HealthUpdate");

        // Garante que a vida não ultrapasse o máximo nem fique abaixo de zero
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        // Atualiza a barra de vida visualmente
        if (healthSlider != null)
        {
            healthSlider.value = currentHealth;
        }

        // Verifica se o player morreu
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Se preferir destruir ao invés de desativar, mude para Destroy(gameObject);
        gameObject.SetActive(false); 
    }
}