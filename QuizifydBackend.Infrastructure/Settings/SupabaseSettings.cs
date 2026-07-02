using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizifydBackend.Infrastructure.Settings
{
    public record SupabaseSettings
    {
        public string Url { get; init; } = string.Empty;
        public string Key { get; init; } = string.Empty;
    }
}
