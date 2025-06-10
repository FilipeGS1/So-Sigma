using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Filipe feiticeiro1;
    public Filipe feiticeiro2;

    void Start()
    {
        feiticeiro1.Nome = "Filipe, o Caótico";
        feiticeiro1.Nivel = 12;
        feiticeiro1.Vida = 120;
        feiticeiro1.Mana = 250;
        feiticeiro1.HabilidadeEspecial = "Explosão Arcana";
        feiticeiro1.TipoMagia = "Magia Caótica";
        
        feiticeiro2.Nome = "Zarek";
        feiticeiro2.Nivel = 8;
        feiticeiro2.Vida = 90;
        feiticeiro2.Mana = 180;
        feiticeiro2.HabilidadeEspecial = "Explosão Arcana";
        feiticeiro2.TipoMagia = "Magia Negra";
        
        Debug.Log($"Feiticeiro 1: {feiticeiro1.Nome}, Nível: {feiticeiro1.Nivel}, Magia: {feiticeiro1.TipoMagia}");
        Debug.Log($"Feiticeiro 2: {feiticeiro2.Nome}, Nível: {feiticeiro2.Nivel}, Magia: {feiticeiro2.TipoMagia}");

        Debug.Log($"{feiticeiro1.Nome} tem nível maior que {feiticeiro2.Nome}? {feiticeiro1.TemNivelMaiorQue(feiticeiro2)}");
    }
}