using System.Collections.Generic;
using RestSharp;

namespace golf1052.YNABAPI
{
    internal static class ExtensionMethods
    {
        public static Dictionary<string, string> HeadersToDictionary(this IReadOnlyCollection<HeaderParameter> headers)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (headers == null)
            {
                return dict;
            }

            foreach (var header in headers)
            {
                if (!dict.ContainsKey(header.Name!))
                {
                    dict.Add(header.Name!, header.Value!.ToString()!);
                }
                else
                {
                    dict[header.Name!] = string.Join(',', dict[header.Name!], header.Value!.ToString());
                }
            }

            return dict;
        }
    }
}
