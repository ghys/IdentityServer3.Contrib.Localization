using System.Linq;
using Thinktecture.IdentityServer.Core.Services.Contrib;
using Xunit;

namespace Unittests
{
    public class AvailableTranslations
    {
        [Theory]
        [InlineData("Default")]
        [InlineData("pirate")]
        [InlineData("de-DE")]
        [InlineData("es-AR")]
        [InlineData("fr-FR")]
        [InlineData("nb-NO")]
        [InlineData("sv-SE")]
        [InlineData("tr-TR")]
        public void ContainsLocales(string locale)
        {
            Assert.Contains(GlobalizedLocalizationService.GetAvailableLocales(), s => s.Equals(locale));
        }

        [Fact]
        public void HasCorrectCount()
        {
            Assert.Equal(8, GlobalizedLocalizationService.GetAvailableLocales().Count());
        }
    }
}