// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompetitiveMapConverter.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="CompetitiveMapDTO" /> to objects of type <see cref="CompetitiveMap" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GW2NET.V1.WorldVersusWorld.Matches.Converters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using GW2NET.Common;
    using GW2NET.V1.WorldVersusWorld.Matches.Json;
    using GW2NET.WorldVersusWorld;

    public partial class CompetitiveMapConverter
    {
        private readonly IConverter<MapBonusDTO, MapBonus> mapBonusConverter;

        private readonly IConverter<ObjectiveDTO, MatchObjective> objectiveConverter;

        private readonly IConverter<int[], Scoreboard> scoreboardConverter;

        /// <summary>Initializes a new instance of the <see cref="CompetitiveMapConverter"/> class.</summary>
        /// <param name="converterFactory"></param>
        /// <param name="scoreboardConverter">The converter for <see cref="Scoreboard"/>.</param>
        /// <param name="objectiveConverter">The converter for <see cref="MatchObjective"/>.</param>
        /// <param name="mapBonusConverter">The converter for <see cref="MapBonus"/>.</param>
        public CompetitiveMapConverter(
            ITypeConverterFactory<CompetitiveMapDTO, CompetitiveMap> converterFactory,
            IConverter<int[], Scoreboard> scoreboardConverter,
            IConverter<ObjectiveDTO, MatchObjective> objectiveConverter,
            IConverter<MapBonusDTO, MapBonus> mapBonusConverter)
            : this(converterFactory)
        {
            if (scoreboardConverter == null)
            {
                throw new ArgumentNullException("scoreboardConverter");
            }

            if (objectiveConverter == null)
            {
                throw new ArgumentNullException("objectiveConverter");
            }

            if (mapBonusConverter == null)
            {
                throw new ArgumentNullException("mapBonusConverter");
            }

            this.scoreboardConverter = scoreboardConverter;
            this.objectiveConverter = objectiveConverter;
            this.mapBonusConverter = mapBonusConverter;
        }

        partial void Merge(CompetitiveMap entity, CompetitiveMapDTO dto, object state)
        {
            var scores = dto.Scores;
            if (scores != null && scores.Length == 3)
            {
                entity.Scores = this.scoreboardConverter.Convert(scores, dto);
            }

            var objectives = dto.Objectives;
            if (objectives != null)
            {
                var values = new List<MatchObjective>(objectives.Count);
                values.AddRange(objectives.Select(objective => this.objectiveConverter.Convert(objective, dto)));
                entity.Objectives = values;
            }

            var bonuses = dto.Bonuses;
            if (bonuses != null)
            {
                var values = new List<MapBonus>(bonuses.Count);
                values.AddRange(bonuses.Select(bonus => this.mapBonusConverter.Convert(bonus, dto)));
                entity.Bonuses = values;
            }
        }
    }
}
