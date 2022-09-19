using System.Globalization;
using Microsoft.Extensions.FileProviders;

namespace Tiveriad.TextTemplating.Extensions;

public static class FileInfoExtensions
{
    private static readonly CultureInfo[] _cultureInfos = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);

    public static CultureInfo? GetCultureInfo(this IFileInfo fileInfo)
    {
        string name = Path.GetFileNameWithoutExtension(fileInfo.Name);
        return _cultureInfos.FirstOrDefault(x => name.Contains(x.Name));
    }
}