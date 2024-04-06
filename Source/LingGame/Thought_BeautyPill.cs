using RimWorld;
using Verse;

namespace LingGame;

public class Thought_BeautyPill : ThoughtWorker
{
    protected override ThoughtState CurrentSocialStateInternal(Pawn pawn, Pawn other)
    {
        if (!other.RaceProps.Humanlike || !RelationsUtility.PawnsKnowEachOther(pawn, other))
        {
            return false;
        }

        if (RelationsUtility.IsDisfigured(other))
        {
            return false;
        }

        return other.health.hediffSet.HasHediff(DefDatabase<HediffDef>.GetNamed("BeautyPill"))
            ? ThoughtState.ActiveAtStage(0)
            : false;
    }
}