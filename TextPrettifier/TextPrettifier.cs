using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TextPrettifierLib
{
    public class TextPrettifier
    {
        public static IDictionary<Regex, MatchEvaluator> WebRules = new Dictionary<Regex, MatchEvaluator>()
        {
                // -- -> –
                { new Regex(@"--", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => "–" },

                // merge several spaces
                { new Regex(@" +", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => " " },

                // space after comma
                { new Regex(@"(?<g1>[a-zа-я0-9]),(?<g2>[a-zа-я0-9])", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => match.Groups["g1"].Value + ", " + match.Groups["g2"].Value },

                // non-breaking space between short and long words
                { new Regex(@"(\s+)(?<g1>[a-zа-я]{1,3})(\s+)(?<g2>[a-zа-я\.]{3,})", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => " " + match.Groups["g1"].Value + "&nbsp;" + match.Groups["g2"].Value },

                // non-breaking space between number and following text
                { new Regex(@"(?<g1>[0-9]+)\s+(?<g2>[a-zа-я]+)", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => match.Groups["g1"].Value + "&nbsp;" + match.Groups["g2"].Value },

                // non-breaking space between long and short words
                { new Regex(@"(?<g1>[a-zа-я]{4,})(\s+)(?<g2>[a-zа-я]{1,3})(?<g3>[\s,\.:;])", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => match.Groups["g1"].Value + "&nbsp;" + match.Groups["g2"].Value + match.Groups["g3"].Value },

                // non-breaking space around dash
                { new Regex(@"\s+(?<v1>[——-])\s+", RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.IgnoreCase), match => "&nbsp;" + match.Groups["v1"].Value + "&nbsp;" }
        };

        public string PrettifyForWeb(string text)
        {
            return this.Prettify(WebRules, text);
        }

        private string Prettify(IDictionary<Regex, MatchEvaluator> rules, string text)
        {
            foreach (KeyValuePair<Regex, MatchEvaluator> rule in rules)
            {
                text = rule.Key.Replace(text, rule.Value);
            }

            return text;
        }
    }
}
