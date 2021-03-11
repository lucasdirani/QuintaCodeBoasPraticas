namespace PokemonStatCalculator.Entities.Moves.MoveEffects
{
    public enum MoveEffectType
    {
        Binding,
        ConsecutivelyExecuted,
        DecreasedPriority,
        IncreasedPriority,
        MoveChangeType,
        CreatingEntryHazard,
        RemovingEntryHazard,
        WeightChange,
        RaiseStatModification,
        LowerStatModification,
        ResetStatModification,
        Flinching,
        InflictStatusCondition,
        Recoil,
        NoHeldItemPowerUp,
        TargetPokemonFormPowerUp,
        TypePowerUp,
        TerrainPowerUp,
        IgnoreAccuracy,
        RestoreHP,
        HighCriticalHit,
    }
}