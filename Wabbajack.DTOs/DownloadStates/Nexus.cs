using System;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Wabbajack.DTOs.JsonConverters;

namespace Wabbajack.DTOs.DownloadStates
{
    [JsonAlias("Nexus")]
    [JsonName("NexusDownloader, Wabbajack.Lib")]
    public class Nexus : ADownloadState, IMetaState
    {
        public string? Name { get; set; }

        public string? Author { get; set; }

        public string? Version { get; set; }

        public Uri? ImageURL { get; set; }

        public bool IsNSFW { get; set; }

        public string? Description { get; set; }

        [JsonPropertyName("GameName")] public Game Game { get; set; }
        public long ModID { get; set; }
        public long FileID { get; set; }

        public override string TypeName => "NexusDownloader+State";
        public override object[] PrimaryKey => new object[] { Game, ModID, FileID };

        public async Task<bool> LoadMetaData()
        {
            return true;
        }
    }
}