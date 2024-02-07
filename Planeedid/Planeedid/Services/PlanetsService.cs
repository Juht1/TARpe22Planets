using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Planeedid.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                       "mercury.png"
                }
            },
            new()
                {
                Name = "Venus",
                Subtitle = "The hottest planet",
                HeroImage = "venus.png",
                Description = "Venus, one of earth's neighbours, named after a love goddess," +
                "also being deemeed (Earth's twin) this planet seems nice, but pull a bit closer" +
                "and it reveals a hellish landscape with heat hot enough to melt lead." +
                "The atmosphere is so thich that the  sun looks like a smear. Venus is" +
                "called the hell planet for these reasons." +
                "It is more of an Earth opposite: Venus spins backward, has a day longer than it's" +
                " year, and lacks any semblance of seasons. A runaway greenhouse effect turned all " +
                "surface water into vapor, which then leaked slowly into space. Asked if there could be " +
                "life on Venus today the absolute awnser is No, but the potential of future life"+
                "is not out of the debate that life could exist in venus.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "earth.png"
                }
            },
            new()
                {
                Name = "Earth",
                Subtitle = "The planet",
                HeroImage = "earth.png",
                Description = "Venus, one of earth's neighbours, named after a love goddess," +
                "also being deemeed (Earth's twin) this planet seems nice, but pull a bit closer" +
                "and it reveals a hellish landscape with heat hot enough to melt lead." +
                "The atmosphere is so thich that the  sun looks like a smear. Venus is" +
                "called the hell planet for these reasons." +
                "It is more of an Earth opposite: Venus spins backward, has a day longer than it's" +
                " year, and lacks any semblance of seasons. A runaway greenhouse effect turned all " +
                "surface water into vapor, which then leaked slowly into space. Asked if there could be " +
                "life on Venus today the absolute awnser is No, but the potential of future life"+
                "is not out of the debate that life could exist in venus.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                
            },
        };
    }
}
