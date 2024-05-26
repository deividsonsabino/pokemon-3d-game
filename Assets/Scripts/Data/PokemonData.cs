using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PokemonStats
{
    HP,
    PhysAttack,
    MagAttack,
    PhysDefense,
    MagDefense,
    Luk
}

[Serializable]
public class ValueContainer
{
    public int value;
    public PokemonStats stats;

    public ValueContainer(int value, PokemonStats stats)
    {
        this.value = value;
        this.stats = stats;
    }
}

[Serializable]
public class ValueBlock
{
    private const int PokemonStatsCount = 6;

    public List<ValueContainer> values;

    public void InitPokemon()
    {
        values = new List<ValueContainer>();

        for (int i = 0; i < PokemonStatsCount; i++)
        {
            values.Add(new ValueContainer(0, (PokemonStats)i));
        }
    }
}


[CreateAssetMenu(menuName = "Data/Pokemon")]
public class PokemonData : ScriptableObject
{
    public string pokemonName;
    public ValueBlock stats;

    [ContextMenu("Init")]
    public void Init()
    {
        stats = new ValueBlock();
        stats.InitPokemon();
    }
}
