namespace Common
{
    public class TagsAndSectionsConstants
    {
        public const string Section1Tag = "1:";

        public const string Section2Tag = "2:";

        public const string MACTag = "MAC:";

        public const string CHKTag = "CHK:";

        public static string GetCodeTemplate(string section) => $"{{{section}[A-z0-9]*}}";

        public const string GetSection4Template = "{4:[\\s\\S]*-}";

        public const string GetSection5Template = "{5:[\\s\\S]*-}";

        public static Dictionary<string, string> tagCodes = new Dictionary<string, string>()
        {
            { "Tag15", ""},
            { "Tag20", ""},
            { "Tag21", ""},
            { "Tag22", ""},
            { "Tag23", ""},
            { "Tag25", ""},
            { "Tag26", ""},
            { "Tag27", ""},
            { "Tag30", ""},
            { "Tag31", ""},
            { "Tag32", ""},
            { "Tag33", ""},
            { "Tag34", ""},
            { "Tag35", ""},
            { "Tag36", ""},
            { "Tag37", ""},
            { "Tag39", ""},
            { "Tag40", ""},
            { "Tag41", ""},
            { "Tag42", ""},
            { "Tag43", ""},
            { "Tag44", ""},
            { "Tag45", ""},
            { "Tag46", ""},
            { "Tag47", ""},
            { "Tag48", ""},
            { "Tag49", ""},
            { "Tag50", ""},
            { "Tag51", ""},
            { "Tag52", ""},
            { "Tag53", ""},
            { "Tag54", ""},
            { "Tag55", ""},
            { "Tag56", ""},
            { "Tag57", ""},
            { "Tag58", ""},
            { "Tag59", ""},
            { "Tag70", ""},
            { "Tag71", ""},
            { "Tag72", ""},
            { "Tag73", ""},
            { "Tag74", ""},
            { "Tag75", ""},
            { "Tag79", ""},
            { "Tag80", ""},
            { "Tag82", ""},
            { "Tag83", ""},
            { "Tag84", ""},
            { "Tag85", ""},
        };
    }
}
