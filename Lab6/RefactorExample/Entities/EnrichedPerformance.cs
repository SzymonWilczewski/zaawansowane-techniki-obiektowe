using RefactorExample.DTOs;

namespace RefactorExample.Entities
{
    public class EnrichedPerformance
    {
        public string PlayId { get; }
        public int Audience { get; }
        public int Amount { get; }
        public Play Play { get; }
        public int VolumeCredits { get; }

        public EnrichedPerformance(string playId, int audience, int amount, Play play, int volumeCredits)
        {
            PlayId = playId;
            Audience = audience;
            Amount = amount;
            Play = play;
            VolumeCredits = volumeCredits;
        }
    }
}
