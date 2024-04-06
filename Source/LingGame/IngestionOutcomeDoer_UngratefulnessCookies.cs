using RimWorld;
using Verse;

namespace LingGame;

public class IngestionOutcomeDoer_UngratefulnessCookies : IngestionOutcomeDoer
{
    protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested, int ingestedCount)
    {
        pawn.relations.ClearAllRelations();
    }
}