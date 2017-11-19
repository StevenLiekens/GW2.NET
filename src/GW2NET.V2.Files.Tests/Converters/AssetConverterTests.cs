// <copyright file="AssetConverterTests.cs" company="GW2.NET Coding Team">
// This product is licensed under the GNU General Public License version 2 (GPLv2). See the License in the project root folder or the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>

namespace GW2NET.V2.Files.Converters
{
    using GW2NET.V2.Files.Json;

    using Xunit;

    public class AssetConverterTests
    {
        private readonly AssetConverter converter = new AssetConverter();

        [Theory]
        [InlineData("map_complete", 528724, "5A4E663071250EC72668C09E3C082E595A380BF7", "https://render.guildwars2.com/file/5A4E663071250EC72668C09E3C082E595A380BF7/528724.png")]
        public void CanConvert(string identifier, int fileId, string fileSignature, string icon)
        {
            var value = new FileDTO
            {
                Id = identifier,
                Icon = icon
            };

            var result = this.converter.Convert(value, null);
            Assert.NotNull(result);
            Assert.NotNull(result.IconFileUrl);
            Assert.Equal(fileId, result.FileId);
            Assert.Equal(fileSignature, result.FileSignature);
            Assert.Equal(icon, result.IconFileUrl.ToString());
        }
    }
}
