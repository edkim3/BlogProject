using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political propagranda")]
        Political,
        [Description("Offensive Language")]
        Language,
        [Description("Drug Reference")]
        Drugs,
        [Description("Threatning Speech")]
        Threatening,
        [Description("Sexual Content")]
        Sexual,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming
    }
}
