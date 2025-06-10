using UnityEngine;

public class Filipe : Personagem
{
    [SerializeField] private string habilidadeEspecial = "Explosão Arcana";
    [SerializeField] private string tipoMagia = "Magia Caótica";

    public string HabilidadeEspecial
    {
        get { return habilidadeEspecial; }
        set { habilidadeEspecial = value; }
    }

    public string TipoMagia
    {
        get { return tipoMagia; }
        set { tipoMagia = value; }
    }
}