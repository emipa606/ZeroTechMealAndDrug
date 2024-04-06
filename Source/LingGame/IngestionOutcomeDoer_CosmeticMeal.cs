using RimWorld;
using Verse;

namespace LingGame;

public class IngestionOutcomeDoer_CosmeticMeal : IngestionOutcomeDoer
{
    private static readonly TraitDef beauty = TraitDef.Named("Beauty");

    protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
    {
        if (!pawn.RaceProps.Humanlike)
        {
            return;
        }

        if (pawn.story.traits.HasTrait(beauty))
        {
            var trait = pawn.story.traits.GetTrait(beauty);
            pawn.story.traits.allTraits.Remove(trait);
        }

        var degree = new[] { -2, -1, 1, 2 }.RandomElement();
        var trait2 = new Trait(beauty, degree);
        pawn.story.traits.GainTrait(trait2);
    }
}