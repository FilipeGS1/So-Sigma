using UnityEngine;

[System.Serializable]
public class Personagem : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int nivel;
    [SerializeField] private int vida;
    [SerializeField] private int mana;
    [SerializeField] private float velocidade;

    // Getters e Setters
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Nivel
    {
        get { return nivel; }
        set { nivel = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public float Velocidade
    {
        get { return velocidade; }
        set { velocidade = value; }
    }

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }
    public bool TemNivelMaiorQue(Personagem outro)
    {
        return this.nivel > outro.nivel;
    }
}