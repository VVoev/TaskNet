using System;
using System.Text;

namespace OldMackDonald.Data.Models.Providers
{
    public static class Verse
    {
        public static StringBuilder ReturnDefaultVerse()
        {
            return new StringBuilder ( 
                $@"Old MacDonald had a farm, E I E I O,{Environment.NewLine}
                      And on his farm he had a @animal, E I E I O.{Environment.NewLine}
                      With a @sound @sound here and a @sound @sound there,{Environment.NewLine}
                      Here a @sound, there a @sound, ev'rywhere a @sound @sound.{Environment.NewLine}
                      Old MacDonald had a farm, E I E I O.{Environment.NewLine}");
        }
    }
}
