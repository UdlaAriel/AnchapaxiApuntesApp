using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnchapaxiApuntesApp.Models
{
    internal class About
    {
        public string Title => "Bloc de notas";
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://www.youtube.com/watch?v=UiNjXsuYFXw";
        public string Message => "Hola mi nombre es Ariel Anchapaxi, me gustan mucho los memes ecuatorianos y no me gusta vivir sin luz.";
    }
}
